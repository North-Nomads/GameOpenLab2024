using GOL.Assets.Project.Scripts.UI.Shuttle.Synthese;
using UnityEngine;

namespace GOL.Assets.Project.Scripts.UI.Shuttle
{
    public class SyntheseProcessor
    {
        
    }

    public class SynthesePage : Page
    {
        [Header("UI Elements")]
        [SerializeField] private GeneUI[] allGenes;
        [SerializeField] private GeneUI baseGeneImage;


        [Header("Cosmetics")]
        [SerializeField] private Color defaultColor;
        [SerializeField] private Color disabledColor;
        [SerializeField] private Sprite disabledSprite;


        public override void HandleClose() => gameObject.SetActive(false);

        public override void HandleOpen()
        {
            foreach (var geneImage in allGenes)
            {
                if (geneImage != baseGeneImage)
                    geneImage.LockGene(disabledSprite, disabledColor);
            }

            baseGeneImage.SetEmpty();
        }
    }
}
