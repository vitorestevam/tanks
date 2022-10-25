using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Complete
{
    public class CommandMove : Command
    {
        private GameObject movableObject;
        private Vector3 Direction;

        public CommandMove(GameObject movableObject, Vector3 Direction)
        {
            this.movableObject = movableObject;
            this.Direction = Direction;
        }

        public override void Execute()
        {
            movableObject.GetComponent<Rigidbody>().MovePosition(movableObject.GetComponent<Rigidbody>().position + Direction);
        }

        public override void Undo()
        {

        }
    }
}