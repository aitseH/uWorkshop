//uScript Generated Code - Build 1.0.3036
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class position : uScriptLogic
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
   System.Single local_10_System_Single = (float) 4;
   System.Single local_11_System_Single = (float) 0;
   UnityEngine.Vector3 local_13_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   System.Single local_14_System_Single = (float) 4;
   UnityEngine.Transform local_2_UnityEngine_Transform = default(UnityEngine.Transform);
   UnityEngine.Vector3 local_3_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_5_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_5_UnityEngine_GameObject_previous = null;
   System.Single local_7_System_Single = (float) 0;
   System.Single local_8_System_Single = (float) 0;
   
   //owner nodes
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_GetPositionFromTransform logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_0 = new uScriptAct_GetPositionFromTransform( );
   UnityEngine.Transform logic_uScriptAct_GetPositionFromTransform_target_0 = default(UnityEngine.Transform);
   System.Boolean logic_uScriptAct_GetPositionFromTransform_getLocal_0 = (bool) false;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_position_0;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_forward_0;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_right_0;
   UnityEngine.Vector3 logic_uScriptAct_GetPositionFromTransform_up_0;
   UnityEngine.Matrix4x4 logic_uScriptAct_GetPositionFromTransform_worldMatrix_0;
   bool logic_uScriptAct_GetPositionFromTransform_Out_0 = true;
   //pointer to script instanced logic node
   uScriptAct_MoveToLocation logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4 = new uScriptAct_MoveToLocation( );
   UnityEngine.GameObject[] logic_uScriptAct_MoveToLocation_targetArray_4 = new UnityEngine.GameObject[] {};
   UnityEngine.Vector3 logic_uScriptAct_MoveToLocation_location_4 = new Vector3( );
   System.Boolean logic_uScriptAct_MoveToLocation_asOffset_4 = (bool) false;
   System.Single logic_uScriptAct_MoveToLocation_totalTime_4 = (float) 0.2;
   bool logic_uScriptAct_MoveToLocation_Out_4 = true;
   bool logic_uScriptAct_MoveToLocation_Cancelled_4 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_6 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_6 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_6;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_6;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_6;
   bool logic_uScriptAct_GetComponentsVector3_Out_6 = true;
   //pointer to script instanced logic node
   uScriptAct_SubtractFloat logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_9 = new uScriptAct_SubtractFloat( );
   System.Single logic_uScriptAct_SubtractFloat_A_9 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_B_9 = (float) 0;
   System.Single logic_uScriptAct_SubtractFloat_FloatResult_9;
   System.Int32 logic_uScriptAct_SubtractFloat_IntResult_9;
   bool logic_uScriptAct_SubtractFloat_Out_9 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_12 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_12 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_12 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_12 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_12;
   bool logic_uScriptAct_SetComponentsVector3_Out_12 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_1 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == local_2_UnityEngine_Transform || false == m_RegisteredForEvents )
      {
         GameObject gameObject = GameObject.Find( "Player" );
         if ( null != gameObject )
         {
            local_2_UnityEngine_Transform = gameObject.GetComponent<UnityEngine.Transform>();
         }
      }
      if ( null == local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_5_UnityEngine_GameObject = GameObject.Find( "Main Camera" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
         
         //setup new listeners
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_1 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_1 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_1 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_1.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_1;
                  component.OnLateUpdate += Instance_OnLateUpdate_1;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_1;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != event_UnityEngine_GameObject_Instance_1 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_1.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_1;
               component.OnLateUpdate -= Instance_OnLateUpdate_1;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_1;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_0.SetParent(g);
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_6.SetParent(g);
      logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_9.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_12.SetParent(g);
   }
   public void Awake()
   {
      
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.Finished += uScriptAct_MoveToLocation_Finished_4;
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
      
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.Finished -= uScriptAct_MoveToLocation_Finished_4;
   }
   
   void Instance_OnUpdate_1(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_1( );
   }
   
   void Instance_OnLateUpdate_1(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_1( );
   }
   
   void Instance_OnFixedUpdate_1(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_1( );
   }
   
   void uScriptAct_MoveToLocation_Finished_4(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_4( );
   }
   
   void Relay_In_0()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a88b6719-83df-4ddf-8faf-b1cbb8799530", "Get_Position_From_Transform", Relay_In_0)) return; 
         {
            {
               logic_uScriptAct_GetPositionFromTransform_target_0 = local_2_UnityEngine_Transform;
               
            }
            {
            }
            {
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
         logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_0.In(logic_uScriptAct_GetPositionFromTransform_target_0, logic_uScriptAct_GetPositionFromTransform_getLocal_0, out logic_uScriptAct_GetPositionFromTransform_position_0, out logic_uScriptAct_GetPositionFromTransform_forward_0, out logic_uScriptAct_GetPositionFromTransform_right_0, out logic_uScriptAct_GetPositionFromTransform_up_0, out logic_uScriptAct_GetPositionFromTransform_worldMatrix_0);
         local_3_UnityEngine_Vector3 = logic_uScriptAct_GetPositionFromTransform_position_0;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetPositionFromTransform_uScriptAct_GetPositionFromTransform_0.Out;
         
         if ( test_0 == true )
         {
            Relay_In_6();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript position.uscript at Get Position From Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_1()
   {
      if (true == CheckDebugBreak("31845d6e-119c-45c9-816c-270dba8f92fa", "Global_Update", Relay_OnUpdate_1)) return; 
      Relay_In_0();
   }
   
   void Relay_OnLateUpdate_1()
   {
      if (true == CheckDebugBreak("31845d6e-119c-45c9-816c-270dba8f92fa", "Global_Update", Relay_OnLateUpdate_1)) return; 
   }
   
   void Relay_OnFixedUpdate_1()
   {
      if (true == CheckDebugBreak("31845d6e-119c-45c9-816c-270dba8f92fa", "Global_Update", Relay_OnFixedUpdate_1)) return; 
   }
   
   void Relay_Finished_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("25b1812d-2972-40f8-abee-55920f98dde1", "Move_To_Location", Relay_Finished_4)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript position.uscript at Move To Location.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("25b1812d-2972-40f8-abee-55920f98dde1", "Move_To_Location", Relay_In_4)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_MoveToLocation_targetArray_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_4, index + 1);
               }
               logic_uScriptAct_MoveToLocation_targetArray_4[ index++ ] = local_5_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocation_location_4 = local_13_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.In(logic_uScriptAct_MoveToLocation_targetArray_4, logic_uScriptAct_MoveToLocation_location_4, logic_uScriptAct_MoveToLocation_asOffset_4, logic_uScriptAct_MoveToLocation_totalTime_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript position.uscript at Move To Location.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Cancel_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("25b1812d-2972-40f8-abee-55920f98dde1", "Move_To_Location", Relay_Cancel_4)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_5_UnityEngine_GameObject_previous != local_5_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_5_UnityEngine_GameObject_previous = local_5_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_MoveToLocation_targetArray_4.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_MoveToLocation_targetArray_4, index + 1);
               }
               logic_uScriptAct_MoveToLocation_targetArray_4[ index++ ] = local_5_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_MoveToLocation_location_4 = local_13_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_MoveToLocation_uScriptAct_MoveToLocation_4.Cancel(logic_uScriptAct_MoveToLocation_targetArray_4, logic_uScriptAct_MoveToLocation_location_4, logic_uScriptAct_MoveToLocation_asOffset_4, logic_uScriptAct_MoveToLocation_totalTime_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript position.uscript at Move To Location.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_6()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("72bf50a5-e532-49df-a623-fc64fa3f0fb0", "Get_Components__Vector3_", Relay_In_6)) return; 
         {
            {
               logic_uScriptAct_GetComponentsVector3_InputVector3_6 = local_3_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_6.In(logic_uScriptAct_GetComponentsVector3_InputVector3_6, out logic_uScriptAct_GetComponentsVector3_X_6, out logic_uScriptAct_GetComponentsVector3_Y_6, out logic_uScriptAct_GetComponentsVector3_Z_6);
         local_7_System_Single = logic_uScriptAct_GetComponentsVector3_X_6;
         local_8_System_Single = logic_uScriptAct_GetComponentsVector3_Z_6;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_6.Out;
         
         if ( test_0 == true )
         {
            Relay_In_9();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript position.uscript at Get Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_9()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("881e2530-6142-412a-91df-03e9002a219f", "Subtract_Float", Relay_In_9)) return; 
         {
            {
               logic_uScriptAct_SubtractFloat_A_9 = local_8_System_Single;
               
            }
            {
               logic_uScriptAct_SubtractFloat_B_9 = local_10_System_Single;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_9.In(logic_uScriptAct_SubtractFloat_A_9, logic_uScriptAct_SubtractFloat_B_9, out logic_uScriptAct_SubtractFloat_FloatResult_9, out logic_uScriptAct_SubtractFloat_IntResult_9);
         local_11_System_Single = logic_uScriptAct_SubtractFloat_FloatResult_9;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SubtractFloat_uScriptAct_SubtractFloat_9.Out;
         
         if ( test_0 == true )
         {
            Relay_In_12();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript position.uscript at Subtract Float.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_12()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5b540aeb-9e48-4a11-8f06-c23b8fde3e29", "Set_Components__Vector3_", Relay_In_12)) return; 
         {
            {
               logic_uScriptAct_SetComponentsVector3_X_12 = local_7_System_Single;
               
            }
            {
               logic_uScriptAct_SetComponentsVector3_Y_12 = local_14_System_Single;
               
            }
            {
               logic_uScriptAct_SetComponentsVector3_Z_12 = local_11_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_12.In(logic_uScriptAct_SetComponentsVector3_X_12, logic_uScriptAct_SetComponentsVector3_Y_12, logic_uScriptAct_SetComponentsVector3_Z_12, out logic_uScriptAct_SetComponentsVector3_OutputVector3_12);
         local_13_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_12;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_12.Out;
         
         if ( test_0 == true )
         {
            Relay_In_4();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript position.uscript at Set Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "position.uscript:2", local_2_UnityEngine_Transform);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5bec0b1b-c274-4d97-ab57-2365a8aca6fe", local_2_UnityEngine_Transform);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "position.uscript:3", local_3_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "cc74d6c9-79a1-4cae-8b3c-019ee85f399e", local_3_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "position.uscript:5", local_5_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "5e8065ab-557a-4135-992d-f35d00fc9f50", local_5_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "position.uscript:7", local_7_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "d44731d6-c198-45ae-be62-ccdd9ecbeeed", local_7_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "position.uscript:8", local_8_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "e6b4f872-a236-4ff1-a736-8406b69eb2dd", local_8_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "position.uscript:10", local_10_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "f2b79843-b562-4cd6-9c64-7082d053741a", local_10_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "position.uscript:11", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "686ad0f9-ff2d-4c02-aa4c-7aaabde8d8dc", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "position.uscript:13", local_13_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "891ea7c1-d5eb-4b28-86aa-e66256a05148", local_13_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "position.uscript:14", local_14_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "420fc8aa-1289-46b5-8613-5229addce81e", local_14_System_Single);
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
