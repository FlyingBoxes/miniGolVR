using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace SaveAndLoadCourse
{
    public class SaveCourseManager
    {
        public void SaveCourse()
        {
            var createdModulesOnScene = GameObject.FindGameObjectsWithTag("CourseCreatorModule");
            var moduleInfos = new List<ModuleInfo>();
            if (moduleInfos == null) throw new ArgumentNullException(nameof(moduleInfos));

            //foreach (GameObject module in createdModulesOnScene)
            //{
            //    var modulePos = module.transform.position;
            //    var prefabName = PrefabUtility.GetCorrespondingObjectFromSource(module).name;

            //    moduleInfos.Add(new ModuleInfo
            //    {
            //        PrefabName = prefabName, 
            //        PosX = modulePos.x, 
            //        PosY = modulePos.y, 
            //        PosZ = modulePos.z
            //    });
            //}

            foreach (var mod in moduleInfos)
            {
                Debug.Log("mod.PrefabName");
            }
        }
    }
}
