using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float objectspeed = 8f;
    private List<GameObject> _activeObject;
    private void FixedUpdate()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        _activeObjects = new List<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = objectspeed * Time.deltaTime * Vector3.left;
        foreach (GameObject activeObject in _activeObject)
        {
            activeObject.transform.position += movement;
            GameManager.UpdateScore(movement);
        }
    }
    IEnumerator Spawn()
    {
        GameManager.UpdateList(_activeObject);

        GameObject challengeObject = Instantiate(GameManager.GetChallengeObject());
        challengeObject.transform.position = new Vector3(GameManager.ScreenBounds.x, 0);
        _activeObject.Add(challengeObject);
        ChallengeObject script = challengeObject.GetComponent<ChallengeObject>();

        yield return new WaitForSeconds(script.challengeTime);
        StartCoroutine(Spawn());
    }

}
