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
    using test;
    using uFrame.ECS;
    using UniRx;
    
    
    [uFrame.Attributes.EventId(2)]
    public partial class clickPlayer2 : object {
        
        [UnityEngine.SerializeField()]
        private Int32 _clickedEntity;
        
        public Int32 clickedEntity {
            get {
                return _clickedEntity;
            }
            set {
                _clickedEntity = value;
            }
        }
    }
}