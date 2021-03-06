﻿namespace BankAccount.Source

module Actions =

    open FSharpx.State
    open Infrastructure
    open Model


    let deposit amount = state {
            let! (account:BankAccount) = getState
            return ()
        }

    let withdraw amount = state {
            let! (account:BankAccount) = getState
            return ()
        }

    let printStatement (printer:IStatementPrinter) account = 
        printer.printHeader()
        printer.print account
        
       