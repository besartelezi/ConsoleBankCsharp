// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using a;
using ConsoleBankCsharp;

Bank bank = new Bank("Big Baba Besart Banking");

bank.Greeting();
bank.HandleRegistration();
BankAccount bankaccount = bank.Register();
bankaccount.HandleBanking();



