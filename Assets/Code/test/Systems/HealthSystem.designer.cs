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
    using uFrame.ECS.APIs;
    using uFrame.ECS.Components;
    using uFrame.ECS.Systems;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    
    
    public partial class HealthSystemBase : uFrame.ECS.Systems.EcsSystem {
        
        private IEcsComponentManagerOf<Orc> _OrcManager;
        
        private IEcsComponentManagerOf<TestComponentNode> _TestComponentNodeManager;
        
        private IEcsComponentManagerOf<SwordComp> _SwordCompManager;
        
        private IEcsComponentManagerOf<HealthComp> _HealthCompManager;
        
        private IEcsComponentManagerOf<ShieldComp> _ShieldCompManager;
        
        private HealthSystemclickedHandler HealthSystemclickedHandlerInstance = new HealthSystemclickedHandler();
        
        public IEcsComponentManagerOf<Orc> OrcManager {
            get {
                return _OrcManager;
            }
            set {
                _OrcManager = value;
            }
        }
        
        public IEcsComponentManagerOf<TestComponentNode> TestComponentNodeManager {
            get {
                return _TestComponentNodeManager;
            }
            set {
                _TestComponentNodeManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SwordComp> SwordCompManager {
            get {
                return _SwordCompManager;
            }
            set {
                _SwordCompManager = value;
            }
        }
        
        public IEcsComponentManagerOf<HealthComp> HealthCompManager {
            get {
                return _HealthCompManager;
            }
            set {
                _HealthCompManager = value;
            }
        }
        
        public IEcsComponentManagerOf<ShieldComp> ShieldCompManager {
            get {
                return _ShieldCompManager;
            }
            set {
                _ShieldCompManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            OrcManager = ComponentSystem.RegisterGroup<OrcGroup,Orc>();
            TestComponentNodeManager = ComponentSystem.RegisterComponent<TestComponentNode>(1);
            SwordCompManager = ComponentSystem.RegisterComponent<SwordComp>(4);
            HealthCompManager = ComponentSystem.RegisterComponent<HealthComp>(2);
            ShieldCompManager = ComponentSystem.RegisterComponent<ShieldComp>(3);
            this.OnEvent<test.clicked>().Subscribe(_=>{ HealthSystemclickedFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void HealthSystemclickedHandler(test.clicked data, Orc entity) {
            var handler = HealthSystemclickedHandlerInstance;
            handler.System = this;
            handler.Event = data;
            handler.entity = entity;
            handler.Execute();
        }
        
        protected void HealthSystemclickedFilter(test.clicked data) {
            var entityItem = OrcManager[data.entity];
            if (entityItem == null) {
                return;
            }
            if (!entityItem.Enabled) {
                return;
            }
            this.HealthSystemclickedHandler(data, entityItem);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("5d2ff56f-35bb-401d-a5a9-5b38793e2e12")]
    public partial class HealthSystem : HealthSystemBase {
        
        private static HealthSystem _Instance;
        
        public HealthSystem() {
            Instance = this;
        }
        
        public static HealthSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}