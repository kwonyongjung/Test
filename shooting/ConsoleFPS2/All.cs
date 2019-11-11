using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class AllObject
{
	virtual public void Update(float a_fDelta) { }
	virtual public void Render() { }
	virtual public void RenderClear() { }
}

