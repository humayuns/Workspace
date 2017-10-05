# 6-10-2017

## Emmet Examples

`nav>ul>li`
```html
<nav>
    <ul>
        <li></li>
    </ul>
</nav>
```

`ul>li*5`
```html
<ul>
    <li></li>
    <li></li>
    <li></li>
    <li></li>
    <li></li>
</ul>
```

`!`
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
    
</body>
</html>
```

## Unity 3D CharacterController.Move
A more complex move function taking absolute movement deltas.

Attempts to move the controller by motion, the motion will only be constrained by collisions. It will slide along colliders. CollisionFlags is the summary of collisions that occurred during the Move. This function does not apply any gravity.
```csharp
using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour {
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    void Update() {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
```
**Reference:** https://docs.unity3d.com/2017.2/Documentation/ScriptReference/CharacterController.Move.html