using GOL.Landscape.Flowers;
using GOL.Landscape.Flowers.Genetics;
using GOL.PlayerScripts;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GOL.Landscape.Tiles
{
    public class Tile : MonoBehaviour
    {
        // HACK: Just for test
        [SerializeField] private GameObject lockPrefab;
        [SerializeField] private GameObject pollutionPrefab;
        [SerializeField] private TileInfo info;
        [SerializeField] private FlowerPot[] pots;
        [SerializeField] private Collider borderCollider;

        public TileInfo Info => info;

        public FlowerPot[] Pots => pots;

        public void ApplyInfo(TileInfo info)
        {
            this.info = info;
            // HACK
            var pollution = Instantiate(pollutionPrefab, transform);
            var lockItem = Instantiate(lockPrefab, transform);
            pollution.transform.position += new Vector3(0.25f, info.PollutionLevel / 2f, 0.25f);
            pollution.transform.localScale = new(1, info.PollutionLevel, 1);
            lockItem.transform.position += new Vector3(0.75f, 0, 0.75f);
            lockItem.transform.localScale += Vector3.up * info.LockLevel;
            for (int i = 0; i < info.Pots.Count; i++)
            {
                info.Pots[i].Initialize(this);
                pots[i].ApplyInfo(info.Pots[i]);
            }
        }

        private void FixedUpdate()
        {
            if (info != null)
            {
                borderCollider.enabled = info.IsLocked;
            }
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.transform.parent.gameObject.TryGetComponent<PlayerInventory>(out var inventory))
            {
                info.OnPlayerEnter(inventory);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.transform.parent.gameObject.TryGetComponent<PlayerInventory>(out var inventory))
            {
                info.OnPlayerLeave(inventory);
            }
        }
    }
}