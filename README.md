# repro 164

To reproduce, do
```
$ git clone -b 164-repro https://github.com/unhammer/csharp-mode
$ cd csharp-mode/
$ emacs -Q -l csharp-mode.el abitslow.cs superslow.cs
```
and type some characters in one of the .cs-files.

Also reproducible in the built-in Pike mode, simply 

```
emacs -Q superslow.cs
```
and `M-x pike-mode RET`.
