using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ShootWeapon : MonoBehaviour
{
    [SerializeField] private GameObject _launchPosition, _bulletPrefab;
    private bool _okayToShoot = false;
    private bool _shootingPaused = false;
    private InputData _inputData;

    // Start is called before the first frame update
    void Start()
    {
        _inputData = GetComponent<InputData>();
    }

    public void PullTheTrigger()
    {
        if (_okayToShoot)
        {
            if (!_shootingPaused)
            {
                 _shootingPaused = true;
                 Fire();
                 StartCoroutine(Pause());
            }
        }
    }

    private void Fire()
    {
        GameObject bullet = Instantiate(_bulletPrefab) as GameObject;
        bullet.SetActive(true);
        bullet.transform.position = _launchPosition.transform.position;
        bullet.transform.rotation = _launchPosition.transform.rotation;

        bullet.GetComponent<Rigidbody>().AddForce(_launchPosition.transform.forward * 50f, ForceMode.Impulse);
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(0.5f);
        _shootingPaused = false;
    }

    public void PickedUpWeaponTrigger()
    {
        _okayToShoot = true;
    }

    public void DroppedWeaponTrigger()
    {
        _okayToShoot = false;
    }
}
