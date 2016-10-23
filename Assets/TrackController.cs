using UnityEngine;
using System.Collections;

namespace Assets
{

    public class TrackController : MonoBehaviour
    {
        private PSMoveAPI api;
        private PSMoveController controller;
        private PSMoveDataContext dataContext;
        private PSMoveHitchWatchdog clock;
        private PSMoveManager manager;
        private PSMovePose pose;
        private PSMoveTest test;
        private PSMoveUtility utility;

        // Use this for initialization
        void Start()
        {
            api = new PSMoveAPI();
            controller = new PSMoveController();
            manager = new PSMoveManager();
            pose = new PSMovePose();
            test = new PSMoveTest();
            utility = new PSMoveUtility();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}