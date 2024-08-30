using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerCounter : BaseCounter{


    public event EventHandler OnPlayerGrabbedObject;
    
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
   
    public override void Interact(Player player) {

        // Spawns object and gives it to player

        if (!player.HasKitchenObject()) {
            // Player is not holding anything and can spawn in the kitchen object

            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);

            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }

    }

    

}
