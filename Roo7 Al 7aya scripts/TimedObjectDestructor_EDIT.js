var timeOut = 1.0;
var detachChildren = false;

private var emitterActive: ParticleEmitter;

function Awake()
{
    emitterActive = transform.GetComponent(ParticleEmitter);
}

function PlayParticle () {
    emitterActive.emit=true;
    //Invoke("StopEmit",timeOut);
	Invoke ("DestroyNow", timeOut);
}

function DestroyNow ()
{
	if (detachChildren) {
		transform.DetachChildren ();
	}
	DestroyObject (gameObject);
}

function StopEmit()
{
    emitterActive.emit=false;
    
}

