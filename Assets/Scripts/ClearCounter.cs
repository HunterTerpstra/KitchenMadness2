using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter {


    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    


    public override void Interact(Player player) {

        if (!HasKitchenObject()) {
            // There is no kitchen object
            if (player.HasKitchenObject()) {
                // Player is holding a kitchen object
                player.GetKitchenObject().SetKitchenObjectParent(this);

            } else {
                // Player not holding a kitchen object
            }

        } else {
            // There is a kitchen object 
            if (player.HasKitchenObject()) {
                // Player is carrying something
                
            } else {
                //Player is not carrying something, give it to the player
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
        
    }

    

}
