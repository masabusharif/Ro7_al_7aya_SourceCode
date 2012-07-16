var scrollSpeed : float = 0.5;

function Update() {
var offset : float = Time.time * scrollSpeed;
renderer.material.mainTextureOffset = Vector2 (offset, 0);
}