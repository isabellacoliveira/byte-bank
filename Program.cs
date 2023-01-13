using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;
using System.Security.Cryptography;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

new ByteBankAtendimento().AtendimentoCliente(); 
