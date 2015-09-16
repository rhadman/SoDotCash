﻿using System.Collections.Generic;
using System.Net;

namespace OFX.Types
{
    /// <summary>
    /// User account use to abstract away the multiple layers required for an account
    /// </summary>
    public class UserAccount
    {
        public OFXCredentials Credentials { get; private set; }
        public OFXFinancialInstitution FinancialInstitution { get; private set; }

        public List<Account> Accounts = new List<Account>();
    }



    /// <summary>
    /// Base account type from which other account types derive.
    /// Container for account data.
    /// </summary>
    public class Account
    {
        public Account(string description, bool active)
        {
            Description = description;
            Active = active;
        }

        /// <summary>
        /// Create proper typed Account from OFX object
        /// </summary>
        /// <param name="ofxAccount">OFX BankAccount object</param>
        /// <returns></returns>
        public static Account Create(global::OFX.BankAccount ofxAccount)
        {
            return BankAccount.Create(ofxAccount);
        }

        /// <summary>
        /// Create proper typed Account from OFX object
        /// </summary>
        /// <param name="ofxAccount">OFX CreditCardAccount object</param>
        /// <returns></returns>
        public static Account Create(global::OFX.CreditCardAccount ofxAccount)
        {
            return new CreditCardAccount(ofxAccount);
        }

        /// <summary>
        /// Description of the account
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Status of the account - whether it's active or not
        /// </summary>
        public bool Active { get; }

        /// <summary>
        /// The type of account - Checking, Savings, Money Market etc
        /// </summary>
        public AccountEnum AccountType { get; private set; }
    }


    /// <summary>
    /// Information for a credit card account
    /// </summary>
    public class CreditCardAccount : Account
    {
        public CreditCardAccount(string accountId, string description, bool active) : base(description, active)
        {
            AccountId = accountId;
        }

        public CreditCardAccount(global::OFX.CreditCardAccount ofxAccount) :
            base("", true)
        {
            AccountId = ofxAccount.ACCTID;
        }

        public override string ToString()
        {
            return "Credit Card (" + AccountId + ")";
        }

        /// <summary>
        /// Account number of this credit card account
        /// </summary>
        public string AccountId { get; }
    }

    /// <summary>
    /// Information for a bank account
    /// </summary>
    public class BankAccount : Account
    {
        public BankAccount(string routingId, string accountId, string description, bool active)
            : base(description, active)
        {
            RoutingId = routingId;
            AccountId = accountId;
        }

        /// <summary>
        /// Create proper typed Account from OFX object
        /// </summary>
        /// <param name="ofxAccount">OFX BankAccount object</param>
        /// <returns></returns>
        public new static Account Create(global::OFX.BankAccount ofxAccount)
        {
            // Route to proper constructor
            if (ofxAccount.ACCTTYPE == AccountEnum.SAVINGS)
                return new SavingsAccount(ofxAccount);
            return new CheckingAccount(ofxAccount);
        }

        /// <summary>
        /// Internal constructor so derived classes can have alternate constructors
        /// </summary>
        protected BankAccount(global::OFX.BankAccount ofxAccount) : 
            base("", true)
        {
            RoutingId = ofxAccount.BANKID;
            AccountId = ofxAccount.ACCTID;
        }

        /// <summary>
        /// Routing ID associated with bank account
        /// </summary>
        public string RoutingId { get; }

        /// <summary>
        /// Account ID associated with bank account
        /// </summary>
        public string AccountId { get; }
    }

    /// <summary>
    /// Derived-type for checking account
    /// </summary>
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string routingId, string accountId, string description, bool active) 
            : base(routingId, accountId, description, active)
        {
            // Stub - ensures the type is correct even though no extra content from parent
        }

        public CheckingAccount(global::OFX.BankAccount ofxAccount) :
            base(ofxAccount)
        {
            // Stub - ensures the type is correct even though no extra content from parent
        }

        public override string ToString()
        {
            return "Checking (" + RoutingId + ":"+ AccountId+ ")";
        }
    }

    /// <summary>
    /// Derived-type for savings account
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string routingId, string accountId, string description, bool active) 
            : base(routingId, accountId, description, active)
        {
            // Stub - ensures the type is correct even though no extra content from parent
        }

        public SavingsAccount(global::OFX.BankAccount ofxAccount) :
            base(ofxAccount)
        {
            // Stub - ensures the type is correct even though no extra content from parent
        }

        public override string ToString()
        {
            return "Savings (" + RoutingId + ":" + AccountId + ")";
        }

    }
}
