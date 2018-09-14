using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit;
using PomFrameworkLib;


namespace PomFrameworkTest
{ 
    class PageMaterialTest : BaseTest
{
    
    [Test()]
    public void Can_Create_Time_Material()
    {
        PageMaterial.CanCreateTimeandMaterial();

    }
}
}
