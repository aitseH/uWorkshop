//uScript Generated Code - Build 1.0.3036
//Generated with Debug Info
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[NodePath("Graphs")]
[System.Serializable]
[FriendlyName("Untitled", "")]
public class move : uScriptLogic
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
   System.Single local_11_System_Single = (float) 0;
   System.Single local_12_System_Single = (float) 0;
   UnityEngine.Vector3 local_14_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject local_16_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_16_UnityEngine_GameObject_previous = null;
   UnityEngine.GameObject local_19_UnityEngine_GameObject = default(UnityEngine.GameObject);
   UnityEngine.GameObject local_19_UnityEngine_GameObject_previous = null;
   UnityEngine.Vector3 local_9_UnityEngine_Vector3 = new Vector3( (float)0, (float)0, (float)0 );
   
   //owner nodes
   UnityEngine.GameObject owner_Connection_3 = null;
   UnityEngine.GameObject owner_Connection_6 = null;
   
   //logic nodes
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_1 = UnityEngine.KeyCode.W;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_1 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_1 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_1 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_4 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_4 = UnityEngine.KeyCode.S;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_4 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_4 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_4 = true;
   //pointer to script instanced logic node
   uScriptAct_RaycastFromCursor logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_8 = new uScriptAct_RaycastFromCursor( );
   UnityEngine.Camera logic_uScriptAct_RaycastFromCursor_Camera_8 = default(UnityEngine.Camera);
   System.Single logic_uScriptAct_RaycastFromCursor_Distance_8 = (float) 1000;
   UnityEngine.LayerMask logic_uScriptAct_RaycastFromCursor_layerMask_8 = 1;
   System.Boolean logic_uScriptAct_RaycastFromCursor_include_8 = (bool) true;
   System.Boolean logic_uScriptAct_RaycastFromCursor_showRay_8 = (bool) false;
   UnityEngine.GameObject logic_uScriptAct_RaycastFromCursor_HitObject_8;
   System.Single logic_uScriptAct_RaycastFromCursor_HitDistance_8;
   UnityEngine.Vector3 logic_uScriptAct_RaycastFromCursor_HitLocation_8;
   UnityEngine.Vector3 logic_uScriptAct_RaycastFromCursor_HitNormal_8;
   bool logic_uScriptAct_RaycastFromCursor_NotObstructed_8 = true;
   bool logic_uScriptAct_RaycastFromCursor_Obstructed_8 = true;
   //pointer to script instanced logic node
   uScriptAct_GetComponentsVector3 logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_10 = new uScriptAct_GetComponentsVector3( );
   UnityEngine.Vector3 logic_uScriptAct_GetComponentsVector3_InputVector3_10 = new Vector3( );
   System.Single logic_uScriptAct_GetComponentsVector3_X_10;
   System.Single logic_uScriptAct_GetComponentsVector3_Y_10;
   System.Single logic_uScriptAct_GetComponentsVector3_Z_10;
   bool logic_uScriptAct_GetComponentsVector3_Out_10 = true;
   //pointer to script instanced logic node
   uScriptAct_SetComponentsVector3 logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_13 = new uScriptAct_SetComponentsVector3( );
   System.Single logic_uScriptAct_SetComponentsVector3_X_13 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Y_13 = (float) 0;
   System.Single logic_uScriptAct_SetComponentsVector3_Z_13 = (float) 0;
   UnityEngine.Vector3 logic_uScriptAct_SetComponentsVector3_OutputVector3_13;
   bool logic_uScriptAct_SetComponentsVector3_Out_13 = true;
   //pointer to script instanced logic node
   uScriptAct_LookAt logic_uScriptAct_LookAt_uScriptAct_LookAt_15 = new uScriptAct_LookAt( );
   UnityEngine.GameObject[] logic_uScriptAct_LookAt_Target_15 = new UnityEngine.GameObject[] {};
   System.Object logic_uScriptAct_LookAt_Focus_15 = "";
   System.Single logic_uScriptAct_LookAt_time_15 = (float) 0;
   uScriptAct_LookAt.LockAxis logic_uScriptAct_LookAt_lockAxis_15 = uScriptAct_LookAt.LockAxis.None;
   bool logic_uScriptAct_LookAt_Out_15 = true;
   //pointer to script instanced logic node
   uScriptAct_OnInputEventFilter logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17 = new uScriptAct_OnInputEventFilter( );
   UnityEngine.KeyCode logic_uScriptAct_OnInputEventFilter_KeyCode_17 = UnityEngine.KeyCode.Space;
   bool logic_uScriptAct_OnInputEventFilter_KeyDown_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyHeld_17 = true;
   bool logic_uScriptAct_OnInputEventFilter_KeyUp_17 = true;
   //pointer to script instanced logic node
   uScriptAct_SpawnPrefab logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18 = new uScriptAct_SpawnPrefab( );
   System.String logic_uScriptAct_SpawnPrefab_PrefabName_18 = "bullet";
   System.String logic_uScriptAct_SpawnPrefab_ResourcePath_18 = "";
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefab_SpawnPoint_18 = default(UnityEngine.GameObject);
   System.String logic_uScriptAct_SpawnPrefab_SpawnedName_18 = "";
   UnityEngine.Vector3 logic_uScriptAct_SpawnPrefab_LocationOffset_18 = new Vector3( (float)0, (float)0, (float)0 );
   UnityEngine.GameObject logic_uScriptAct_SpawnPrefab_SpawnedGameObject_18;
   System.Int32 logic_uScriptAct_SpawnPrefab_SpawnedInstancedID_18;
   bool logic_uScriptAct_SpawnPrefab_Immediate_18 = true;
   
   //event nodes
   UnityEngine.GameObject event_UnityEngine_GameObject_Instance_7 = default(UnityEngine.GameObject);
   
   //property nodes
   
   //method nodes
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_2 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_2 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_2 = (float) 0.1;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_5 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_5 = (float) 0;
   System.Single method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_5 = (float) -0.1;
   #pragma warning restore 414
   
   //functions to refresh properties from entities
   
   void SyncUnityHooks( )
   {
      SyncEventListeners( );
      if ( null == logic_uScriptAct_RaycastFromCursor_Camera_8 || false == m_RegisteredForEvents )
      {
         GameObject gameObject = GameObject.Find( "/Main Camera" );
         if ( null != gameObject )
         {
            logic_uScriptAct_RaycastFromCursor_Camera_8 = gameObject.GetComponent<UnityEngine.Camera>();
         }
      }
      if ( null == logic_uScriptAct_SpawnPrefab_SpawnPoint_18 || false == m_RegisteredForEvents )
      {
         logic_uScriptAct_SpawnPrefab_SpawnPoint_18 = GameObject.Find( "/Player" ) as UnityEngine.GameObject;
      }
      if ( null == local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_16_UnityEngine_GameObject = GameObject.Find( "Player" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
         
         //setup new listeners
      }
      if ( null == local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         local_19_UnityEngine_GameObject = GameObject.Find( "Player" ) as UnityEngine.GameObject;
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_19_UnityEngine_GameObject_previous )
         {
            {
               uScript_Input component = local_19_UnityEngine_GameObject_previous.GetComponent<uScript_Input>();
               if ( null != component )
               {
                  component.KeyEvent -= Instance_KeyEvent_0;
               }
            }
         }
         
         local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_19_UnityEngine_GameObject )
         {
            {
               uScript_Input component = local_19_UnityEngine_GameObject.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = local_19_UnityEngine_GameObject.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_0;
               }
            }
         }
      }
      if ( null == owner_Connection_3 || false == m_RegisteredForEvents )
      {
         owner_Connection_3 = parentGameObject;
      }
      if ( null == owner_Connection_6 || false == m_RegisteredForEvents )
      {
         owner_Connection_6 = parentGameObject;
      }
   }
   
   void RegisterForUnityHooks( )
   {
      SyncEventListeners( );
      //if our game object reference was changed then we need to reset event listeners
      if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         
         local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
         
         //setup new listeners
      }
      //if our game object reference was changed then we need to reset event listeners
      if ( local_19_UnityEngine_GameObject_previous != local_19_UnityEngine_GameObject || false == m_RegisteredForEvents )
      {
         //tear down old listeners
         if ( null != local_19_UnityEngine_GameObject_previous )
         {
            {
               uScript_Input component = local_19_UnityEngine_GameObject_previous.GetComponent<uScript_Input>();
               if ( null != component )
               {
                  component.KeyEvent -= Instance_KeyEvent_0;
               }
            }
         }
         
         local_19_UnityEngine_GameObject_previous = local_19_UnityEngine_GameObject;
         
         //setup new listeners
         if ( null != local_19_UnityEngine_GameObject )
         {
            {
               uScript_Input component = local_19_UnityEngine_GameObject.GetComponent<uScript_Input>();
               if ( null == component )
               {
                  component = local_19_UnityEngine_GameObject.AddComponent<uScript_Input>();
               }
               if ( null != component )
               {
                  component.KeyEvent += Instance_KeyEvent_0;
               }
            }
         }
      }
   }
   
   void SyncEventListeners( )
   {
      if ( null == event_UnityEngine_GameObject_Instance_7 || false == m_RegisteredForEvents )
      {
         event_UnityEngine_GameObject_Instance_7 = uScript_MasterComponent.LatestMaster;
         if ( null != event_UnityEngine_GameObject_Instance_7 )
         {
            {
               uScript_Update component = event_UnityEngine_GameObject_Instance_7.GetComponent<uScript_Update>();
               if ( null == component )
               {
                  component = event_UnityEngine_GameObject_Instance_7.AddComponent<uScript_Update>();
               }
               if ( null != component )
               {
                  component.OnUpdate += Instance_OnUpdate_7;
                  component.OnLateUpdate += Instance_OnLateUpdate_7;
                  component.OnFixedUpdate += Instance_OnFixedUpdate_7;
               }
            }
         }
      }
   }
   
   void UnregisterEventListeners( )
   {
      if ( null != local_19_UnityEngine_GameObject )
      {
         {
            uScript_Input component = local_19_UnityEngine_GameObject.GetComponent<uScript_Input>();
            if ( null != component )
            {
               component.KeyEvent -= Instance_KeyEvent_0;
            }
         }
      }
      if ( null != event_UnityEngine_GameObject_Instance_7 )
      {
         {
            uScript_Update component = event_UnityEngine_GameObject_Instance_7.GetComponent<uScript_Update>();
            if ( null != component )
            {
               component.OnUpdate -= Instance_OnUpdate_7;
               component.OnLateUpdate -= Instance_OnLateUpdate_7;
               component.OnFixedUpdate -= Instance_OnFixedUpdate_7;
            }
         }
      }
   }
   
   public override void SetParent(GameObject g)
   {
      parentGameObject = g;
      
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_4.SetParent(g);
      logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_8.SetParent(g);
      logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_10.SetParent(g);
      logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_13.SetParent(g);
      logic_uScriptAct_LookAt_uScriptAct_LookAt_15.SetParent(g);
      logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.SetParent(g);
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.SetParent(g);
      owner_Connection_3 = parentGameObject;
      owner_Connection_6 = parentGameObject;
   }
   public void Awake()
   {
      
      logic_uScriptAct_LookAt_uScriptAct_LookAt_15.Finished += uScriptAct_LookAt_Finished_15;
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.FinishedSpawning += uScriptAct_SpawnPrefab_FinishedSpawning_18;
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
      
      logic_uScriptAct_LookAt_uScriptAct_LookAt_15.Update( );
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.Update( );
   }
   
   public void OnDestroy()
   {
      logic_uScriptAct_LookAt_uScriptAct_LookAt_15.Finished -= uScriptAct_LookAt_Finished_15;
      logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.FinishedSpawning -= uScriptAct_SpawnPrefab_FinishedSpawning_18;
   }
   
   void Instance_KeyEvent_0(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_KeyEvent_0( );
   }
   
   void Instance_OnUpdate_7(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnUpdate_7( );
   }
   
   void Instance_OnLateUpdate_7(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnLateUpdate_7( );
   }
   
   void Instance_OnFixedUpdate_7(object o, System.EventArgs e)
   {
      //reset event call
      //if it ever goes above MaxRelayCallCount before being reset
      //then we assume it is stuck in an infinite loop
      if ( relayCallCount < MaxRelayCallCount ) relayCallCount = 0;
      
      //fill globals
      //relay event to nodes
      Relay_OnFixedUpdate_7( );
   }
   
   void uScriptAct_LookAt_Finished_15(object o, System.EventArgs e)
   {
      //fill globals
      //relay event to nodes
      Relay_Finished_15( );
   }
   
   void uScriptAct_SpawnPrefab_FinishedSpawning_18(object o, System.EventArgs e)
   {
      //fill globals
      //links to SpawnedGameObject = 0
      //links to SpawnedInstancedID = 0
      //relay event to nodes
      Relay_FinishedSpawning_18( );
   }
   
   void Relay_KeyEvent_0()
   {
      if (true == CheckDebugBreak("f4d8cc1c-54c0-4466-bf66-c01ab5bdf5dd", "Input_Events", Relay_KeyEvent_0)) return; 
      Relay_In_1();
      Relay_In_4();
      Relay_In_17();
   }
   
   void Relay_In_1()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("b1c40c70-6b6c-46ca-a87e-4c5d2019c8dc", "Input_Events_Filter", Relay_In_1)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.In(logic_uScriptAct_OnInputEventFilter_KeyCode_1);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_1.KeyHeld;
         
         if ( test_0 == true )
         {
            Relay_Translate_2();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_2()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("fcdba35d-8814-4af0-ab9a-55746a5f692f", "UnityEngine_Transform", Relay_Translate_2)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_3.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_2, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_2, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_2);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_4()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("70d0450f-b6c1-4ffc-a956-b6a3a8606e4e", "Input_Events_Filter", Relay_In_4)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_4.In(logic_uScriptAct_OnInputEventFilter_KeyCode_4);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_4.KeyHeld;
         
         if ( test_0 == true )
         {
            Relay_Translate_5();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Translate_5()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("55b7fadd-519b-477d-9176-6135f9c540a7", "UnityEngine_Transform", Relay_Translate_5)) return; 
         {
            {
            }
            {
            }
            {
            }
         }
         {
            UnityEngine.Transform component;
            component = owner_Connection_6.GetComponent<UnityEngine.Transform>();
            if ( null != component )
            {
               component.Translate(method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_x_5, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_y_5, method_Detox_ScriptEditor_Plug_UnityEngine_GameObject_z_5);
            }
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at UnityEngine.Transform.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_OnUpdate_7()
   {
      if (true == CheckDebugBreak("367396e1-4e6c-4625-a2c9-e930b425dc90", "Global_Update", Relay_OnUpdate_7)) return; 
      Relay_In_8();
   }
   
   void Relay_OnLateUpdate_7()
   {
      if (true == CheckDebugBreak("367396e1-4e6c-4625-a2c9-e930b425dc90", "Global_Update", Relay_OnLateUpdate_7)) return; 
   }
   
   void Relay_OnFixedUpdate_7()
   {
      if (true == CheckDebugBreak("367396e1-4e6c-4625-a2c9-e930b425dc90", "Global_Update", Relay_OnFixedUpdate_7)) return; 
   }
   
   void Relay_In_8()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         uScriptDebug.Log( "[Detox.ScriptEditor.LogicNode] ", uScriptDebug.Type.Message);
         if (true == CheckDebugBreak("4391aada-2e2d-4850-8341-e4c2b7d5f1f1", "Raycast_From_Mouse_Cursor", Relay_In_8)) return; 
         {
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
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_8.In(logic_uScriptAct_RaycastFromCursor_Camera_8, logic_uScriptAct_RaycastFromCursor_Distance_8, logic_uScriptAct_RaycastFromCursor_layerMask_8, logic_uScriptAct_RaycastFromCursor_include_8, logic_uScriptAct_RaycastFromCursor_showRay_8, out logic_uScriptAct_RaycastFromCursor_HitObject_8, out logic_uScriptAct_RaycastFromCursor_HitDistance_8, out logic_uScriptAct_RaycastFromCursor_HitLocation_8, out logic_uScriptAct_RaycastFromCursor_HitNormal_8);
         local_9_UnityEngine_Vector3 = logic_uScriptAct_RaycastFromCursor_HitLocation_8;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_RaycastFromCursor_uScriptAct_RaycastFromCursor_8.Obstructed;
         
         if ( test_0 == true )
         {
            Relay_In_10();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Raycast From Mouse Cursor.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_10()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("a2b18170-5b57-4e2c-abf7-3be8e7ccb261", "Get_Components__Vector3_", Relay_In_10)) return; 
         {
            {
               logic_uScriptAct_GetComponentsVector3_InputVector3_10 = local_9_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_10.In(logic_uScriptAct_GetComponentsVector3_InputVector3_10, out logic_uScriptAct_GetComponentsVector3_X_10, out logic_uScriptAct_GetComponentsVector3_Y_10, out logic_uScriptAct_GetComponentsVector3_Z_10);
         local_11_System_Single = logic_uScriptAct_GetComponentsVector3_X_10;
         local_12_System_Single = logic_uScriptAct_GetComponentsVector3_Z_10;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_GetComponentsVector3_uScriptAct_GetComponentsVector3_10.Out;
         
         if ( test_0 == true )
         {
            Relay_In_13();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Get Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_13()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("8fb63da6-9639-406a-aa71-b1bf3fbe5f7f", "Set_Components__Vector3_", Relay_In_13)) return; 
         {
            {
               logic_uScriptAct_SetComponentsVector3_X_13 = local_11_System_Single;
               
            }
            {
            }
            {
               logic_uScriptAct_SetComponentsVector3_Z_13 = local_12_System_Single;
               
            }
            {
            }
         }
         logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_13.In(logic_uScriptAct_SetComponentsVector3_X_13, logic_uScriptAct_SetComponentsVector3_Y_13, logic_uScriptAct_SetComponentsVector3_Z_13, out logic_uScriptAct_SetComponentsVector3_OutputVector3_13);
         local_14_UnityEngine_Vector3 = logic_uScriptAct_SetComponentsVector3_OutputVector3_13;
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_SetComponentsVector3_uScriptAct_SetComponentsVector3_13.Out;
         
         if ( test_0 == true )
         {
            Relay_In_15();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Set Components (Vector3).  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_Finished_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bc236634-6d3a-4eef-af66-b8a9c039da12", "Look_At", Relay_Finished_15)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Look At.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_15()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("bc236634-6d3a-4eef-af66-b8a9c039da12", "Look_At", Relay_In_15)) return; 
         {
            {
               int index = 0;
               {
                  //if our game object reference was changed then we need to reset event listeners
                  if ( local_16_UnityEngine_GameObject_previous != local_16_UnityEngine_GameObject || false == m_RegisteredForEvents )
                  {
                     //tear down old listeners
                     
                     local_16_UnityEngine_GameObject_previous = local_16_UnityEngine_GameObject;
                     
                     //setup new listeners
                  }
               }
               if ( logic_uScriptAct_LookAt_Target_15.Length <= index)
               {
                  System.Array.Resize(ref logic_uScriptAct_LookAt_Target_15, index + 1);
               }
               logic_uScriptAct_LookAt_Target_15[ index++ ] = local_16_UnityEngine_GameObject;
               
            }
            {
               logic_uScriptAct_LookAt_Focus_15 = local_14_UnityEngine_Vector3;
               
            }
            {
            }
            {
            }
         }
         logic_uScriptAct_LookAt_uScriptAct_LookAt_15.In(logic_uScriptAct_LookAt_Target_15, logic_uScriptAct_LookAt_Focus_15, logic_uScriptAct_LookAt_time_15, logic_uScriptAct_LookAt_lockAxis_15);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Look At.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_17()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("5b71c9e7-63c1-4508-8089-38854a88f5af", "Input_Events_Filter", Relay_In_17)) return; 
         {
            {
            }
         }
         logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.In(logic_uScriptAct_OnInputEventFilter_KeyCode_17);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         bool test_0 = logic_uScriptAct_OnInputEventFilter_uScriptAct_OnInputEventFilter_17.KeyDown;
         
         if ( test_0 == true )
         {
            Relay_In_18();
         }
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Input Events Filter.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_FinishedSpawning_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("916922b1-8880-4cf4-a21f-c9de5d67c702", "Spawn_Prefab", Relay_FinishedSpawning_18)) return; 
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Spawn Prefab.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   void Relay_In_18()
   {
      if ( relayCallCount++ < MaxRelayCallCount )
      {
         if (true == CheckDebugBreak("916922b1-8880-4cf4-a21f-c9de5d67c702", "Spawn_Prefab", Relay_In_18)) return; 
         {
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
            {
            }
         }
         logic_uScriptAct_SpawnPrefab_uScriptAct_SpawnPrefab_18.In(logic_uScriptAct_SpawnPrefab_PrefabName_18, logic_uScriptAct_SpawnPrefab_ResourcePath_18, logic_uScriptAct_SpawnPrefab_SpawnPoint_18, logic_uScriptAct_SpawnPrefab_SpawnedName_18, logic_uScriptAct_SpawnPrefab_LocationOffset_18, out logic_uScriptAct_SpawnPrefab_SpawnedGameObject_18, out logic_uScriptAct_SpawnPrefab_SpawnedInstancedID_18);
         
         //save off values because, if there are multiple, our relay logic could cause them to change before the next value is tested
         
      }
      else
      {
         uScriptDebug.Log( "Possible infinite loop detected in uScript move.uscript at Spawn Prefab.  If this is in error you can change the Maximum Node Recursion in the Preferences Panel and regenerate the script.", uScriptDebug.Type.Error);
      }
   }
   
   private void UpdateEditorValues( )
   {
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "move.uscript:9", local_9_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "ad5b6c57-8536-42bd-a4be-96c67a3b5e64", local_9_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "move.uscript:11", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "67eef4d1-7fc5-4ca1-bc18-5cc52f76f89b", local_11_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "move.uscript:12", local_12_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "83a9e53b-1000-4f2a-b5e1-ab1fb2488993", local_12_System_Single);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "move.uscript:14", local_14_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "2638cac6-d6b6-40ba-b26d-1b93e8e45579", local_14_UnityEngine_Vector3);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "move.uscript:16", local_16_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "78361dd9-d3cf-4f72-87d2-fa3e03992416", local_16_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "move.uscript:19", local_19_UnityEngine_GameObject);
      uScript_MasterComponent.LatestMasterComponent.UpdateNodeValue( "56fafaba-cb4c-427b-b215-623d3c1580d9", local_19_UnityEngine_GameObject);
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
