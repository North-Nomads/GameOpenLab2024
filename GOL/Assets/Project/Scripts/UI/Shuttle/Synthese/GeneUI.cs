using System;
using UnityEngine;
using UnityEngine.UI;

namespace GOL.Assets.Project.Scripts.UI.Shuttle.Synthese
{
    public class GeneUI : MonoBehaviour, IButton
    {
        [SerializeField] private Image hexImage;
        [SerializeField] private Image innerImage;
        [SerializeField] private Text text;
        [SerializeField] private Image outlineImage;
        // private Gene _selectedGene;

        private void OnEnable()
        {
            OnCursorLeave();
        }

        public void LockGene(Sprite lockedGeneImage, Color lockedGeneColor)
        {
            hexImage.color = lockedGeneColor;
            innerImage.sprite = lockedGeneImage;
            text.text = string.Empty;
        }

        public void HandleGeneSetInSlot(/*Gene gene*/)
        {
            /*image.sprite = gene.icon*/
            /*text.text = gene.bonusValue.ToString();*/
        }

        internal void SetEmpty()
        {
            innerImage.sprite = null;
            text.text = string.Empty;
        }

        public void ExecuteOnClick()
        {
            // Open gene selection page
        }

        public void OnCursorLeave()
        {
            outlineImage.gameObject.SetActive(false);
        }

        public void OnCursorEntered()
        {
            outlineImage.gameObject.SetActive(true);
        }
    }
}
