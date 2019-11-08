using System;

abstract class Scene
{
	virtual public void Update(float a_fDelta) { }
	virtual public void Update(eKey p_Temp) { }
	virtual public void Render() { }
}