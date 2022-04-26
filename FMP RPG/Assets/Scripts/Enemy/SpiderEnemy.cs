using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{

	public int EnemyHealth = 10;
	public GameObject TheSpider;
	public int SpiderStatus;
	public int BaseXP = 10;
	public int CalculatedXP;
<<<<<<< HEAD
	public SpiderAI SpiderAIScript;

	void start()
    {
		SpiderAIScript = GetComponent<SpiderAI>();
    }
=======
>>>>>>> 487e3e5864de925aeabf770e32c1e21947b243cf

	void DeductPoints(int DamageAmount)
	{
		EnemyHealth -= DamageAmount;
	}

	void Update()
	{
		if (EnemyHealth <= 0)
		{
			if (SpiderStatus == 0)
			{

				StartCoroutine(DeathSpider());
			}
		}
	}

	IEnumerator DeathSpider()
	{
		SpiderAIScript.enabled = false;
		SpiderStatus = 6;
		CalculatedXP = BaseXP * GlobalLevel.CurrentLevel;
		GlobalXP.CurrentXP += CalculatedXP;
<<<<<<< HEAD
		yield return new WaitForSeconds (0.5f);
		TheSpider.GetComponent<Animation> ().Play ("die");
=======
		yield return new WaitForSeconds(0.5f);
		TheSpider.GetComponent<Animation>().Play("die");
>>>>>>> 487e3e5864de925aeabf770e32c1e21947b243cf
	}
}
