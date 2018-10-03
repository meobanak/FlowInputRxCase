/*
 * Created by Ranorex
 * User: Admin
 * Date: 2018-09-05
 * Time: 9:10 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace TestCase
{
    /// <summary>
    /// Description of module_example.
    /// </summary>
    [TestModule("9FFF62E4-40BE-40DC-A22E-9489BD69EDEA", ModuleType.UserCode, 1)]
    public class module_example : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public module_example()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
        }
    }
}
