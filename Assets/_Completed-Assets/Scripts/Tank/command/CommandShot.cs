using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;


namespace Complete
{
    public class CommandShot : Command
    {
        private Transform parent;
        private float speed;
        private Rigidbody ammo;
        public CommandShot(Transform parent, Rigidbody ammo, float speed)
        {
            this.parent = parent;
            this.ammo = ammo;
            this.speed = speed;
        }

        public override void Execute()
        {
            Rigidbody shellInstance = Rigidbody.Instantiate(ammo, this.parent.position, this.parent.rotation) as Rigidbody;

            // Set the shell's velocity to the launch force in the fire position's forward direction.
            shellInstance.velocity = this.speed * this.parent.forward;
        }

        public override void Undo()
        {

        }
    }

}