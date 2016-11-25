using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactNative.Bridge;
using ReactNative.Collections;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Popups;

namespace test.intelexalex.winTest
{
    class winTestModule : ReactContextNativeModuleBase
    {
        private const String testMessage = "This is a test message";

        public winTestModule(ReactContext reactContext) : base(reactContext){}

        public override string Name
        {
            get
            {
                return "winTest";
            }
        }

        [ReactMethod]
        public void getMessage(ICallback callback)
        {
            callback.Invoke(testMessage);
        }
    }
}
