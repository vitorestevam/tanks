using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Complete
{
    public class CommandTurn : Command
    {
        private GameObject movableObject;
        private Quaternion rotation;

        public CommandTurn(GameObject movableObject, float rotation)
        {
            this.movableObject = movableObject;
            this.rotation = Quaternion.Euler(0f, rotation, 0f);
        }

        public override void Execute()
        {
            movableObject.GetComponent<Rigidbody>().MoveRotation(movableObject.GetComponent<Rigidbody>().rotation * this.rotation);
        }

        public override void Undo()
        {

        }
    }
}