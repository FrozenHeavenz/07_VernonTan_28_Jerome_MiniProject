using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TestSuite
    {
        private GameObject GameLvl1;
        private GameObject GameLvl2;


        [SetUp]
        public void SetUp()
        {
            GameLvl1 = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/GameLvl1"));
            
        }

        [TearDown]
        public void TearDown()
        {
            Object.Destroy(GameLvl1);

        }

        [UnityTest]
        public IEnumerator CheckForSpawningPositiveX()
        {
            SpawnerScript spawnerScript = GameObject.Find("GameManager").GetComponent<SpawnerScript>();

            int initialCount = 0;

            yield return new WaitForSeconds(2f);

            Assert.Greater(spawnerScript.EnemyCountPosX , initialCount);
        }

        [UnityTest]
        public IEnumerator CheckForSpawningNegativeX()
        {
            SpawnerScript spawnerScript = GameObject.Find("GameManager").GetComponent<SpawnerScript>();

            int initialCount = 0;

            yield return new WaitForSeconds(2f);

            Assert.Greater(spawnerScript.EnemyCountNegX, initialCount);
        }

        [UnityTest]
        public IEnumerator CheckForSpawningPositiveY()
        {
            SpawnerScript spawnerScript = GameObject.Find("GameManager").GetComponent<SpawnerScript>();

            int initialCount = 0;

            yield return new WaitForSeconds(2f);

            Assert.Greater(spawnerScript.EnemyCountPosY, initialCount);
        }

        [UnityTest]
        public IEnumerator CheckForSpawningNegativeY()
        {
            SpawnerScript spawnerScript = GameObject.Find("GameManager").GetComponent<SpawnerScript>();

            int initialCount = 0;

            yield return new WaitForSeconds(2f);

            Assert.Greater(spawnerScript.EnemyCountNegY, initialCount);
        }

        [UnityTest]
        public IEnumerator CheckForRedEnemyCollision()
        {
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            yield return new WaitForSeconds(2f);

            GameObject spawnedObject = GameObject.FindGameObjectWithTag("Enemy2");
            GameObject player = GameObject.FindGameObjectWithTag("Player");


            float initialHealth = 20;
            spawnedObject.transform.position = player.transform.position;

            Assert.Less(GameManager.Hp, initialHealth);
        }

        [UnityTest]
        public IEnumerator CheckForBlueEnemyCollision()
        {
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            yield return new WaitForSeconds(2f);

            GameObject spawnedObject = GameObject.FindGameObjectWithTag("Enemy");
            GameObject player = GameObject.FindGameObjectWithTag("Player");


            float initialHealth = 20;
            spawnedObject.transform.position = player.transform.position;

            Assert.Less(GameManager.Hp, initialHealth);
        }

        [UnityTest]
        public IEnumerator CheckForGreenEnemyCollision()
        {
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            yield return new WaitForSeconds(2f);

            GameObject spawnedObject = GameObject.FindGameObjectWithTag("Enemy1");
            GameObject player = GameObject.FindGameObjectWithTag("Player");


            float initialHealth = 20;
            spawnedObject.transform.position = player.transform.position;

            Assert.Less(GameManager.Hp, initialHealth);
        }
    }
}
