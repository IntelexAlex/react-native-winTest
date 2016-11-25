using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactNative.Bridge;
using ReactNative.Modules.Core;
using ReactNative.UIManager;

namespace test.intelexalex.winTest
{
    class winTestPackage : IReactPackage
    {
        public IReadOnlyList<INativeModule> CreateNativeModules(ReactContext reactContext)
        {
            return new List<INativeModule>
            {
                new winTestModule(reactContext)
            };
        }

        public IReadOnlyList<Type> CreateJavaScriptModulesConfig()
        {
            return Array.Empty<Type>();
        }

        public IReadOnlyList<IViewManager> CreateViewManagers(ReactContext reactContext)
        {
            return new List<IViewManager>(0);
        }
    }
}
