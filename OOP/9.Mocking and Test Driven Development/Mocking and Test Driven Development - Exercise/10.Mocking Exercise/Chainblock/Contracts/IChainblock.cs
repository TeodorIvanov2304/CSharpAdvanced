﻿using System.Collections.Generic;
using Chainblock.Models.Enumerations;

namespace Chainblock.Contracts
{
    public interface IChainblock
    {
        int Count { get; }

        void Add(ITransaction tx);

        bool Contains(int id);

        void ChangeTransactionStatus(int id, TransactionStatus newStatus);

        void RemoveTransactionById(int id);

        ITransaction GetById(int id);

        //TODO:
        //IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status);

        //IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status);

        //IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status);

        //IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById();

        //IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender);

        //IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver);

        //IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount);

        //IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount);

        //IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi);

        //IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi);
    }
}