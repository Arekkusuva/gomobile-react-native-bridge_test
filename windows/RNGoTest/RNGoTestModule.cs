using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Go.Test.RNGoTest
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNGoTestModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNGoTestModule"/>.
        /// </summary>
        internal RNGoTestModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNGoTest";
            }
        }
    }
}
