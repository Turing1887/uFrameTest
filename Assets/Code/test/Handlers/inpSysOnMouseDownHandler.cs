// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace test {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.ECS.UnityUtilities;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class inpSysOnMouseDownHandler {
        
        public meineTestComp Source;
        
        private uFrame.ECS.UnityUtilities.MouseDownDispatcher _Event;
        
        private uFrame.ECS.Systems.EcsSystem _System;
        
        private object ActionNode3_message = default( System.Object );
        
        private string StringNode2 = "Hallo\n";
        
        public uFrame.ECS.UnityUtilities.MouseDownDispatcher Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.Systems.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode3_message = StringNode2;
            // ActionNode
            while (this.DebugInfo("","06c14cfc-1908-4976-b773-d82c0a78ec38", this) == 1) yield return null;
            // Visit uFrame.ECS.Actions.DebugLibrary.LogMessage
            uFrame.ECS.Actions.DebugLibrary.LogMessage(ActionNode3_message);
            yield break;
        }
    }
}