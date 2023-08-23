BaseFrameWork
=============
Contents
--------
## 1. Plugins
### 1) UniRx   
## 2. Resources
### 1) Art   
##### (1) Material   
##### (2) UnityChan   
### 2) Data   
### 3) Prefabs   
##### (1) Camera   
##### (2) UI   
### 4) Sounds   
##### (1) Bgm   
##### (2) UnityChan   
## 3. Scenes
### 1) InGame
### 2) LogIn
## 4. Scripts
### 1) Controllers   
##### (1) CameraCtrl   
##### (2) PlayerCtrl   
   - Controls Player Character by MousePointer LayCasting   
### 2) Data   
##### (1) DataContents   
   - inherit ILoader in DataMgr and implement individual Data classes   
### 3) Managers   
##### (1) Managers   
   - Main Manager of project whitch init and clear other managers   
   - Written as SingleTon pattern   
##### (2) DataMgr
   - ILoader interface is included
   - Load JSON file in path as TestAsset
   - when initted, Saves loaded JSON files as Dictionary
##### (3) InputMgr   
   - Invoke Actions when inputs are entered   
##### (4) PoolMgr   
##### (5) ResourceMgr   
##### (6) SceneMgrEx   
##### (7) SoundMgr   
##### (8) UIMgr   
### 4) Scenes   
##### (1) BaseScene   
##### (2) InGameScene      
##### (3) LogInScence      
### 5) UI   
* PopUp   
##### (1) UI_Btn   
##### (2) UI_PopUp   
* Scene   
##### (1) UI_Inven   
##### (2) UI_Scene   
* SubItem   
##### (1) UI_Inven_Item    
### 6) Utility   
##### (1) Define   
##### (2) ExtensionMethod   
##### (3) Utils   
