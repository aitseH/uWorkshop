//uScript Generated Code - Build 1.0.3036
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class bullet : uScriptLogic
{

   #pragma warning disable 414
   GameObject parentGameObject = null;
   uScript_GUI thisScriptsOnGuiListener = null; 
   bool m_RegisteredForEvents = false;
   delegate void ContinueExecution();
   ContinueExecution m_ContinueExecution;
   bool m_Breakpoint = false;
   const int MaxRelayCallCount = 1000;
   int relayCallCount = 0;
   
   //externally exposed events
   
   //external parameters
   
   //local nodes
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_3 = null;
   UnityEngine.GameObject owner_Connection_4 = null;
   UnityEngine.GameObject owner_Connection_6 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_AddRelativeForce logic_uScriptAct_AddRelativeForce_uScriptAct_AddRelativeForce_1 = new uScriptAct_AddRelativeForce( );
   UnityEngine.GameObject logic_uScriptAct_AddRelativeForce_Target_1 = default(UnityEngine.GameObject);
   UnityEngine.Vector3 logic_uScriptAct_AddRelativeForce_Force_1 = new Vector3( (float)0, (float)0, (float)1200 );
   System.Single logic_uScriptAct_AddRelativeForce_Scale_1 = (float) 0;
   System.Boolean logic_uScriptAct_AddRelativeForce_UseForceMode_1 = (bool) false;
   UnityEngine.ForceMode logic_uScriptAct_AddRelativeForce_ForceModeType_1 = UnityEngine.ForceMode.Force;
   bool logic_uScriptAct_AddRelativeForce_Out_1 = true;
   //pointer to script instanced logic node
   uScriptAct_Destroy logic_uScriptAct_Destroy_uScriptAct_Destroy_2 = new uScriptAct_Destroy( );
   UnityEngine.GameObject[] logic_uScriptAct_Destroy_Target_2 = new UnityEngine.GameObject[] {};
   System.Single logic_uScriptAct_Destroy_DelayTime_2 = (float) 0;
   bool logic_uScriptAct_Destroy_Out_2 = true;
   bool logic_uScriptAct_Destroy_ObjectsDestroyed_2 = true;
   bool logic_uScriptAct_Destroy_WaitOneTick_2 = false;
   //pointer to script instanced logic node
   uScriptAct_Delay logic_uScriptAct_Delay_uScriptAct_Delay_5 = new uScriptAct_Delay( );
   System.Single logic_uScriptAct_Delay_Duration_5 = (float) 2;
   System.Boolean logic_uScriptAct_Delay_SingleFrame_5 = (bool) false;
   bool logic_uScriptAct_Delay_Immediate_5 = true;
   bool logic_uScriptAct_Delay_AfterDelay_5 = true;
   bool logic_uScriptAct_Delay_Stopped_5 = true;
   bool logic_uScriptAct_Delay_DrivenDelay_5 = false;
   
   //event nodes
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == owner_Connection_3 || false == m_RegisteredForEvents )
      {
         owner_Connection_3 = parentGameObject;
      }
      if ( null == owner_Connection_4 || false == m_RegisteredForEvents )
      {
         owner_Connection_4 = parentGameObject;
      }
      if ( null == owner_Connection_6 || false == m_RegisteredForEvents )
      {
         owner_Connection_6 = parentGameObject;
         if ( null != owner_Connection_6 )
         {
            {
               uScript_Global component = owner_Connection_6.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = owner_Connection_6.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_0;
                  component.uScriptLateStart += Instance_uScriptLateStart_0;
               }
            }
         }
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //reset event listeners if needed
      //this isn't a variable node so it should only be called once per enabling of the script
      //if it's called twice there would be a double event registration (which is an error)
      if ( false == m_RegisteredForEvents )
      {
         if ( null != owner_Connection_6 )
         {
            {
               uScript_Global component = owner_Connection_6.GetComponent<uScript_Global>();
               if ( null == component )
               {
                  component = owner_Connection_6.AddComponent<uScript_Global>();
               }
               if ( null != component )
               {
                  component.uScriptStart += Instance_uScriptStart_0;
                  component.uScriptLateStart += Instance_uScriptLateStart_0;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != owner_Connection_6 )
      {
         {
            uScript_Global component = owner_Connection_6.GetComponent<uScript_Global>();
            if ( null != component )
            {
               component.uScriptStart -= Instance_uScriptStart_0;
               component.uScriptLateStart -= Instance_uScriptLateStart_0;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_AddRelativeForce_uScriptAct_AddRelativeForce_1.SetParent(g);
      logic_uScriptAct_Destroy_uScriptAct_Destroy_2.SetParent(g);
      logic_uScriptAct_Delay_uScriptAct_Delay_5.SetParent(g);
      owner_Connection_3 = parentGameObject;
      owner_Connection_4 = parentGameObject;
      owner_Connection_6 = parentGameObject;
   }
   public void Awake()
   {
      
   }
   
   public void Start()
   {
      SyncUnityHooks( );
      m_RegisteredForEvents = true;
      
   }
   
   public void OnEnable()
   {
      RegisterForUnityHooks( );
      m_RegisteredForEvents = true;
   }
   
   public void OnDisable()
   {
      UnregisterEventListeners( );
      m_RegisteredForEvents = false;
   }
   
   public void Update()
   {
      //reset each Update, and increments each method call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      if ( null != m_ContinueExecution )
      {
         ContinueExecution continueEx = m_ContinueExecution;
         m_ContinueExecution = null;
         m_Breakpoint = false;
         continueEx( );
         return;
      }
      UpdateEditorValues( );
      
      //other scripts might have added GameObjects with event scripts
      //so we need to verify all our event listeners are registered
      SyncEventListeners( );
      
      if (true == logic_uScriptAct_Destroy_WaitOneTick_2)
      {
         Relay_WaitOneTick_2();
      }
      if (true == logic_uScriptAct_Delay_DrivenDelay_5)
      {
         Relay_DrivenDelay_5();
      }
   }
   
   public void OnDestroy()
   {
   }
   
   void Instance_uScriptStart_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptStart_0( );
   }
   
   void Instance_uScriptLateStart_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_uScriptLateStart_0( );
   }
   
   void Relay_uScriptStart_0()
   {
      if (true == CheckDebugBreak("4a6a122e-78a8-4df0-be6d-15b90414ed28", "uScript_Events", Relay_uScriptStart_0)) return; 
      Relay_In_1();
      Relay_In_5();
   }
   
   void Relay_uScriptLateStart_0()
   {
      if (true == CheckDebugBreak("4a6a122e-78a8-4df0-be6d-15b90414ed28", "uScript_Events", Relay_uScriptLateStart_0)) return; 
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8a1364b9-9c00-427e-a2f0-264b913e5fe8", "Add_Relative_Force", Relay_In_1)) return; 
         {
            {
               logic_uScriptAct_AddRelativeForce_Target_1 = owner_Connection_4;
               
            }
            {
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_AddRelativeForce_uScriptAct_AddRelativeForce_1.In(logic_uScriptAct_AddRelativeForce_Target_1, logic_uScriptAct_AddRelativeForce_Force_1, logic_uScriptAct_AddRelativeForce_Scale_1, logic_uScriptAct_AddRelativeForce_UseForceMode_1, logic_uScriptAct_AddRelativeForce_ForceModeType_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript bullet.uscript at Add Relative Force.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("d6684f16-06d2-4557-8e4e-217ca0bda2a5", "Destroy", Relay_In_2)) return; 
         {
            {
               int index = 0;
               if ( logic_uScriptAct_Destroy_Target_2.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_2, index + 1);
               }
               logic_uScriptAct_Destroy_Target_2[ index++ ] = owner_Connection_3;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_uScriptAct_Destroy_2.In(logic_uScriptAct_Destroy_Target_2, logic_uScriptAct_Destroy_DelayTime_2);
         logic_uScriptAct_Destroy_WaitOneTick_2 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript bullet.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_WaitOneTick_2( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
               int index = 0;
               if ( logic_uScriptAct_Destroy_Target_2.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_Destroy_Target_2, index + 1);
               }
               logic_uScriptAct_Destroy_Target_2[ index++ ] = owner_Connection_3;
               
            }
            {
            }
         }
         logic_uScriptAct_Destroy_WaitOneTick_2 = logic_uScriptAct_Destroy_uScriptAct_Destroy_2.WaitOneTick();
         if ( true == logic_uScriptAct_Destroy_WaitOneTick_2 )
         {
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript bullet.uscript at Destroy.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   void Relay_In_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1e560ed6-b9c2-41c4-9925-dc2615ea2172", "Delay", Relay_In_5)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_5.In(logic_uScriptAct_Delay_Duration_5, logic_uScriptAct_Delay_SingleFrame_5);
         logic_uScriptAct_Delay_DrivenDelay_5 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_5.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript bullet.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Stop_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("1e560ed6-b9c2-41c4-9925-dc2615ea2172", "Delay", Relay_Stop_5)) return; 
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_uScriptAct_Delay_5.Stop(logic_uScriptAct_Delay_Duration_5, logic_uScriptAct_Delay_SingleFrame_5);
         logic_uScriptAct_Delay_DrivenDelay_5 = true;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_Delay_uScriptAct_Delay_5.AfterDelay;
         
         if ( test_0 == true )
         {
            Relay_In_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript bullet.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_DrivenDelay_5( )
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         {
            {
            }
            {
            }
         }
         logic_uScriptAct_Delay_DrivenDelay_5 = logic_uScriptAct_Delay_uScriptAct_Delay_5.DrivenDelay();
         if ( true == logic_uScriptAct_Delay_DrivenDelay_5 )
         {
            if ( logic_uScriptAct_Delay_uScriptAct_Delay_5.AfterDelay == true )
            {
               Relay_In_2();
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript bullet.uscript at Delay.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   private void UpdateEditorValues( )
   {
   }
   bool CheckDebugBreak(string guid, string name, ContinueExecution method)
   {
      if (true == m_Breakpoint) return true;
      
      if (true == uScript_MasterComponent.FindBreakpoint(guid))
      {
         if (uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint == guid)
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = "";
         }
         else
         {
            uScript_MasterComponent.LatestMasterComponent.CurrentBreakpoint = guid;
            UpdateEditorValues( );
            UnityEngine.Debug.Log("uScript BREAK Node:" + name + " ((Time: " + Time.time + "");
            UnityEngine.Debug.Break();
            #if (!UNITY_FLASH)
            m_ContinueExecution = new ContinueExecution(method);
            #endif
            m_Breakpoint = true;
            return true;
         }
      }
      return false;
   }
}
