using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace SpatialPartitionPattern
{
    public class Amount : MonoBehaviour
    {
        public GameController gameController;
        public TextMeshProUGUI textBox;
        void Update()
        {
            textBox.text = "Number of Soldiers: " + gameController.numberOfSoldiers.ToString();
        }
    }
}
