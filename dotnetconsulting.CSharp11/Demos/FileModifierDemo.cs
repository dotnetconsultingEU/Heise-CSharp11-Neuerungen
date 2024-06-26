﻿// Disclaimer
// Dieser Quellcode ist als Vorlage oder als Ideengeber gedacht. Er kann frei und ohne 
// Auflagen oder Einschränkungen verwendet oder verändert werden.
// Jedoch wird keine Garantie übernommen, dass eine Funktionsfähigkeit mit aktuellen und 
// zukünftigen API-Versionen besteht. Der Autor übernimmt daher keine direkte oder indirekte 
// Verantwortung, wenn dieser Code gar nicht oder nur fehlerhaft ausgeführt wird.
// Für Anregungen und Fragen stehe ich jedoch gerne zur Verfügung.

// Thorsten Kansy, www.dotnetconsulting.eu

using System.Diagnostics;

namespace dotnetconsulting.CSharp11.Demos;

internal class FileModifierDemo
{
    internal static void Run()
    {
        Debugger.Break();

        // Nicht verfügbar, da in
        // einer anderen Datei definiert
        // IFile ifc;
        // FileClass fc;
        FileRunA.Run();
        FileRunB.Run();

        Debugger.Break();
    }
}