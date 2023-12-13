using CesiumForUnity;
using Unity.Mathematics;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    float RotationSpeed = 30.0f;
    float TiltSpeed = 30.0f;
    float MaxTilt = 15.0f;
    float currentVelocity;
    CesiumCameraController cameraController;
    private CesiumGeoreference _georeference;
    private CesiumGlobeAnchor _globeAnchor;

    private CharacterController _controller;

    private Vector3 _velocity = Vector3.zero;
    private float _lookSpeed = 30.0f;

    // These numbers are borrowed from Cesium for Unreal.
    private float _acceleration = 20000.0f;
    private float _deceleration = 9999999959.0f;

    private float _maxSpeed = 100.0f; // Maximum speed with the speed multiplier applied.


    // Start is called before the first frame update
    void Start()
    {
        // unklar
        cameraController = gameObject.GetComponent<CesiumCameraController>();
        cameraController.defaultMaximumSpeed = 7;
        this._georeference = this.gameObject.GetComponentInParent<CesiumGeoreference>();
        this._globeAnchor = this.gameObject.GetComponentInParent<CesiumGlobeAnchor>();
        InitializeController();
    }


    void InitializeController()
    {
        // wenn CharacterController Komponente != null, dann als lokale Referenz speichern 
        if (this.gameObject.GetComponent<CharacterController>() != null)
        {
            Debug.LogWarning(
                "A CharacterController component was manually " +
                "added to the CesiumCameraController's game object. " +
                "This may interfere with the CesiumCameraController's movement.");

            // CharacterController wird in die Variable ._controller gespeichert
            this._controller = this.gameObject.GetComponent<CharacterController>();
        }
        else
        {
            this._controller = this.gameObject.AddComponent<CharacterController>();

            // ! nochmal nachgucken was die folgenden Zeile genau macht !
            this._controller.hideFlags = HideFlags.HideInInspector;
        }

        this._controller.radius = 1.0f;
        this._controller.height = 1.0f;
        this._controller.center = Vector3.zero;
        this._controller.detectCollisions = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Eingabewerte werden gelesen
        float verticalMovement = Input.GetAxis("Vertical");
        float horizontalRotation = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        // nur f�r die Ausgabe
        Debug.Log("Horizontal: " + horizontalRotation + " Vertical: " + verticalMovement);

        float verticalRotation = 0.0f;

        // Bestimmung der drei Geschwindigkeiten
        if (Input.GetKey(KeyCode.F1))
        {
            //cameraController.defaultMaximumSpeed = 3;
            this._maxSpeed = 3;
        }
        if (Input.GetKey(KeyCode.F2))
        {
            //cameraController.defaultMaximumSpeed = 15;
            this._maxSpeed = 15;
        }

        if (Input.GetKey(KeyCode.F3))
        {
            //cameraController.defaultMaximumSpeed = 50;
            this._maxSpeed = 50;
        }

        // nach unten schauen
        if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalRotation = 1.0f;
        }
        // nach oben schauen
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalRotation = -1.0f;
        }

        Vector3 movementInput = new Vector3(0.0f, 0.0f, verticalMovement);

        Move(movementInput);
        // neues Vektorobjekt wird berechnet anhand der Rotationsgeschwindigkeit und der Eingabewerte (zum drehen)
        Vector3 rotation = new Vector3(verticalRotation, horizontalRotation, 0.0f) * RotationSpeed * Time.deltaTime;
        // neues Vektorobjekt wird berechnet anhand der Kippgeschwindigkeit und der Eingabewerte (kippen beim drehen)
        Vector3 tilt = new Vector3(0.0f, 0.0f, -horizontalRotation) * TiltSpeed * Time.deltaTime;

        //transform.position = transform.position + movement * Speed * Time.deltaTime;

        this.Rotate(horizontalRotation, verticalRotation);

        // Rotation und Kippung wird ausgef�hrt
        //transform.Rotate(rotation);


        // Limit the tilt on the Z-axis to a maximum of 45 degrees
        // die Rotation in grad Zahlen wird �bergeben (Z-Achse die von vorne nach hinten f�hrt) 
        float zRotation = transform.localEulerAngles.z;
        // die Gradzahlen sollen zwischen -180 und +180 liegen, dementsprechnend wird es hier umgerechnet 
        zRotation = (zRotation > 180) ? zRotation - 360 : zRotation; // Conversion to range -180 to +180
        // Debug.Log(MaxTilt);

        // falls die Rotation gr��er als 15 Grad ist, dann wird stattdessen weiterhin nur 15 Grad verwendet
        if (Mathf.Abs(zRotation) < MaxTilt)
        {
            if (_maxSpeed > 15)
                transform.Rotate(tilt);
        }

        // wenn keine Eingabe zur Kippung stattfindet, dann tue die folgenden Dinge...
        if (horizontalRotation == 0)
        {
            // es soll wieder langsam in die Anfangsposition kommen, hierbei wird der �bergangswert berechnet
            float zReset = Mathf.SmoothDampAngle(zRotation, 0, ref currentVelocity, 8f / RotationSpeed);
            float zRotationChange = zReset - zRotation;
            //Debug.Log(zRotationChange);
            transform.Rotate(0, 0, zRotationChange);
        }
    }

    /// <summary>
    /// Moves the controller with the given player input.
    /// </summary>
    /// <remarks>
    /// The x-coordinate affects movement along the transform's right axis.
    /// The y-coordinate affects movement along the georeferenced up axis.
    /// The z-coordinate affects movement along the transform's forward axis.
    /// X-Achse = transform, Y-Achse = Georeference
    /// </remarks>
    /// <param name="movementInput">The player input.</param>
    private void Move(Vector3 movementInput)
    {
        // rechts-links und vorw�rts-r�ckw�rts Eingabewerte werden gespeichert
        Vector3 inputDirection =
            this.transform.right * movementInput.x + this.transform.forward * movementInput.z;

        if (this._georeference != null)
        {
            // unklar!
            double3 positionECEF = this._globeAnchor.positionGlobeFixed;
            double3 upECEF = CesiumWgs84Ellipsoid.GeodeticSurfaceNormal(positionECEF);
            double3 upUnity =
                this._georeference.TransformEarthCenteredEarthFixedDirectionToUnity(upECEF);
            // Bewegung anhand der Y-Achse
            inputDirection = (float3)inputDirection + (float3)upUnity * movementInput.y;
        }

        if (inputDirection != Vector3.zero)
        {
            // If the controller was already moving, handle the direction change
            // separately from the magnitude of the velocity.
            if (this._velocity.magnitude > 0.0f)
            {
                // 
                Vector3 directionChange = inputDirection - this._velocity.normalized;
                // neue Geschwindigkeit wird in Abh�ngigkeit der alten Geschwindigkeit berechnet 
                this._velocity +=
                    directionChange * this._velocity.magnitude * Time.deltaTime;
            }
            // Geschwindigkeit in Abh�ngigkeit der Beschleunigung wird berechnet
            this._velocity += inputDirection * this._acceleration * Time.deltaTime;
            // Geschwindigkeit darf Max.Geschwindigkeit nicht �berschreiten
            this._velocity = Vector3.ClampMagnitude(this._velocity, this._maxSpeed);
        }
        else
        {
            // Decelerate - Geschwindigkeit solange reduzieren bis Sie bei 0 ist 
            float speed = Mathf.Max(
                this._velocity.magnitude - this._deceleration * Time.deltaTime,
                0.0f);
            // aktuller Wert wird �bergeben
            this._velocity = Vector3.ClampMagnitude(this._velocity, speed);
        }

        if (this._velocity != Vector3.zero)
        {
            // Bewegungsvektor wird am Controller �bergeben damit Bewegung ausgef�hrt wird
            this._controller.Move(this._velocity * Time.deltaTime);
            // Other controllers may disable detectTransformChanges to control their own
            // movement, but the globe anchor should be synced even if detectTransformChanges
            // is false.
            // unklar  
            if (!this._globeAnchor.detectTransformChanges)
            {
                this._globeAnchor.Sync();
            }
        }
    }

    /// <summary>
    /// Rotate the camera with the specified amounts.
    /// </summary>
    /// <remarks>
    /// Horizontal rotation (i.e. looking left or right) corresponds to rotation around the Y-axis.
    /// Vertical rotation (i.e. looking up or down) corresponds to rotation around the X-axis.
    /// </remarks>
    /// <param name="horizontalRotation">The amount to rotate horizontally, i.e. around the Y-axis.</param>
    /// <param name="verticalRotation">The amount to rotate vertically, i.e. around the X-axis.</param>
    private void Rotate(float horizontalRotation, float verticalRotation)
    {
        if (horizontalRotation == 0.0f && verticalRotation == 0.0f)
        {
            return;
        }

        float valueX = verticalRotation * this._lookSpeed * Time.smoothDeltaTime;
        float valueY = horizontalRotation * this._lookSpeed * Time.smoothDeltaTime;

        // Rotation around the X-axis occurs counter-clockwise, so the look range
        // maps to [270, 360] degrees for the upper quarter-sphere of motion, and
        // [0, 90] degrees for the lower. Euler angles only work with positive values,
        // so map the [0, 90] range to [360, 450] so the entire range is [270, 450].
        // This makes it easy to clamp the values.
        float rotationX = this.transform.localEulerAngles.x;
        if (rotationX <= 90.0f)
        {
            rotationX += 360.0f;
        }

        float newRotationX = Mathf.Clamp(rotationX - valueX, 270.0f, 450.0f);
        float newRotationY = this.transform.localEulerAngles.y + valueY;
        //this.transform.localRotation =
        //    Quaternion.Euler(newRotationX, newRotationY, this.transform.localEulerAngles.z);
        cameraController.transform.localRotation =
            Quaternion.Euler(newRotationX, newRotationY, this.transform.localEulerAngles.z);
    }

}

