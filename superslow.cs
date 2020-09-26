using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading;

namespace Thing
{
    class WriteTextFile
    {
	static void Main()
	{
	    // INSERT TEXT HERE TO EXPERIENCE SLOWNESS

	}

	private static string prettyFailure(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure0(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure2(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure4(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}























    }
	class WriteTextFile2
    {
	static void Main()
	{
	    kake ost;kake ost;

	}

	private static string prettyFailure(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure0(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure2(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure4(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}























    }



    class Z{
	static void Main()
	{
	    // insert text here

	}

	private static string prettyFailure(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure0(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure2(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure4(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}























    }

	class WriteTextFile23
    {
	static void Main()
	{
	    kake ost;kake ost;

	}

	private static string prettyFailure(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure0(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure2(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure4(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}























    }

    	class WriteTextFile2b
    {
	static void Main()
	{
	    kake ost;kake ost;

	}

	private static string prettyFailure(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure0(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure2(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure4(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}























    }

    	class WriteTextFile2c
    {
	static void Main()
	{
	    kake ost;kake ost;

	}

	private static string prettyFailure(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure0(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure2(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure4(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}























    }
    	class WriteTextFile2s
    {
	static void Main()
	{
	    kake ost;kake ost;

	}

	private static string prettyFailure(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure0(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure2(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure4(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}























    }	class WriteTextFile2sdf
    {
	static void Main()
	{
	    kake ost;kake ost;

	}

	private static string prettyFailure(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure0(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure2(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure4(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}























    }
    	class WriteTextFile2dsaf
    {
	static void Main()
	{
	    kake ost;kake ost;

	}

	private static string prettyFailure(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure0(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure2(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}
	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure3(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}

	private static string prettyFailure4(Foo o) {
	    bool emptyMessage = o.Message == "" || o.Message == " Message start: ";
	    return  o.FooOperation + "/" + o.BarOperation
		+ (o.Xyzzy == ""        ? " (No XYZZY)" : ", XYZZY " + o.Xyzzy)
		+ (o.TempFooNo == null ? ""             : ", TempFooNo " + o.TempFooNo)
		+ ": MEH "  + o.Meh
		+ (o.Pri == ""        ? ""             : ", PRI " + o.Pri)
		+ ", BLAH '" + o.Blah + "'"
		+ ", ASLDKF "  + o.Asldkf
		+ ", PENGUINS "  + o.Penguins
		+ ", ITEM '" + o.Item + "'"
		+ ", SESQUIPEDALIAN "  + o.Sesquipedalian
		+ (o.SesquipedalianOld == ""     ? ""             : " (from SESQUIPEDALIAN " + o.SesquipedalianOld + ")")
		+ (o.Dada == ""        ? ""             : ", DADA '" + o.Dada + "'")
		+ (emptyMessage          ? ""             : "; '" + o.Message + "'")
		+ "."
		;
	}























    }

}
