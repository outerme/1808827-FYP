﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vIDsafe
{
    [Serializable]
    public class Identity
    {
        //private List<Credential> _credentials = new List<Credential>();

        private Dictionary<string, Credential> _credentials = new Dictionary<string, Credential>();

        private string _name;
        private string _email;
        private string _usage;

        private int _healthScore;
        private int _weakCredentials;
        private int _conflictCredentials;
        private int _compromisedCredentials;
        private int _safeCredentials;

        public Identity(string name)
        {
            this._name = name;
        }

        private void ResetCredentialCounts()
        {
            _healthScore = 100;

            _weakCredentials = 0;
            _conflictCredentials = 0;
            _compromisedCredentials = 0;
            _safeCredentials = 0;
        }

        public void CalculateHealthScore()
        {
            ResetCredentialCounts();

            _safeCredentials = _credentials.Count - (_weakCredentials + _conflictCredentials + _compromisedCredentials);

            if (_credentials.Count > 0)
            {
                _healthScore = (_safeCredentials) / _credentials.Count * 100;
            }
        }

        public int GetCredentialCount()
        {
            if (_credentials.Count > 0)
            {
                return _credentials.Count;
            }

            return 0;
        }

        public Credential GetCredential(string key)
        {
            if (_credentials.ContainsKey(key))
            {
                return _credentials[key];
            }
            else
            {
                return new Credential("");
            }
        }

        public Dictionary<string, Credential> Credentials => _credentials;

        public string NewCredential(string username)
        {
            Credential credential = new Credential(username);

            string uniqueID = Guid.NewGuid().ToString();

            _credentials.Add(uniqueID, credential);

            FormvIDsafe.Main.User.SaveVault();

            return uniqueID;
        }

        public void DeleteCredential(string key)
        {
            if (_credentials.ContainsKey(key))
            {
                _credentials.Remove(key);
                FormvIDsafe.Main.User.SaveVault();
            }
        }

        public string Name =>_name;

        public string Email => _email;

        public string Usage => _usage;

        public int HealthScore => _healthScore;
        public int WeakCredentials => _weakCredentials;

        public int ConflictCredentials => _conflictCredentials;

        public int CompromisedCredentials => _compromisedCredentials;

        public int SafeCredentials => _safeCredentials;

        public void SetDetails(string name, string email, string usage)
        {
            this._name = name;
            this._email = email;
            this._usage = usage;

            FormvIDsafe.Main.User.SaveVault();
        }
    }
}
