;;; csharp-mode.el --- C# mode derived mode  -*- lexical-binding: t; -*-

;; Author     : Theodor Thornhill
;; Maintainer : Jostein Kjønigsen <jostein@gmail.com>
;;            : Theodor Thornhill <theo@thornhill.no>
;; Created    : September 2020
;; Modified   : 2020
;; Version    : 0.1.0
;; Keywords   : c# languages oop mode
;; X-URL      : https://github.com/josteink/csharp-mode

;;
;; This program is free software; you can redistribute it and/or modify
;; it under the terms of the GNU General Public License as published by
;; the Free Software Foundation; either version 2 of the License, or
;; (at your option) any later version.
;;
;; This program is distributed in the hope that it will be useful,
;; but WITHOUT ANY WARRANTY; without even the implied warranty of
;; MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
;; GNU General Public License for more details.
;;
;; You should have received a copy of the GNU General Public License
;; along with this program; see the file COPYING.  If not, write to
;; the Free Software Foundation, Inc., 59 Temple Place - Suite 330,
;; Boston, MA 02111-1307, USA.

;;; Code:

(require 'cc-mode)
(require 'cc-langs)

(eval-when-compile
  (require 'cc-fonts))

(eval-and-compile
  (c-add-language 'csharp-mode 'java-mode))

(defgroup csharp nil
  "Major mode for editing C# code."
  :group 'prog-mode)

(c-lang-defconst c-make-mode-syntax-table
  csharp `(lambda ()
            (let ((table (make-syntax-table)))
	      (c-populate-syntax-table table)
              (modify-syntax-entry ?@ "_" table)
	      table)))

(c-lang-defconst c-identifier-syntax-modifications
  csharp (append '((?@ . "w"))
	         (c-lang-const c-identifier-syntax-modifications)))

(c-lang-defconst c-get-state-before-change-functions
  csharp '(c-parse-quotes-before-change
	   c-before-change-check-unbalanced-strings
	   c-before-change-check-<>-operators))

(c-lang-defconst c-before-font-lock-functions
  csharp '(c-depropertize-new-text
	   c-after-change-escape-NL-in-string
	   c-parse-quotes-after-change
	   c-after-change-mark-abnormal-strings
	   c-restore-<>-properties
	   c-change-expand-fl-region))

(c-lang-defconst c-symbol-start
  csharp (concat "[" c-alpha "_@]"))

(c-lang-defconst c-identifier-ops
  csharp '((left-assoc ".")))

(c-lang-defconst c-overloadable-operators
  csharp '("+" "-" "*" "/" "%" "&" "|" "^" "<<" ">>" "=="
	   "!=" ">" "<" ">=" "<="))

(c-lang-defconst c-multiline-string-start-char
  csharp ?@)

(c-lang-defconst c-primitive-type-kwds
  csharp '("bool" "byte" "sbyte" "char" "decimal" "double" "float" "int" "uint"
	   "long" "ulong" "short" "ushort" "void" "object" "string" "var"))

(c-lang-defconst c-type-modifier-kwds
  csharp '("readonly" "const" "volatile" "new"))

(c-lang-defconst c-brace-list-decl-kwds
  csharp '("enum" "new"))

(c-lang-defconst c-other-block-decl-kwds
  csharp '("namespace"))

(c-lang-defconst c-using-kwds
  csharp '("using"))

(c-lang-defconst c-modifier-kwds
  csharp '("abstract" "const" "default" "final" "native" "private" "protected"
	   "public" "partial" "internal" "readonly" "static" "event" "transient"
	   "volatile" "sealed" "ref" "out" "virtual" "implicit" "explicit"
	   "fixed" "override" "params" "async" "await" "extern" "unsafe"
           "get" "set"))

(c-lang-defconst c-colon-type-list-kwds
  csharp '("class" "struct" "interface"))

(c-lang-defconst c-block-stmt-1-kwds
  csharp '("do" "else" "finally" "try"))

(c-lang-defconst c-block-stmt-1-2-kwds
  csharp '("try"))

(c-lang-defconst c-block-stmt-2-kwds
  csharp '("for" "if" "switch" "while" "catch" "foreach" "fixed" "checked"
	   "unchecked" "using" "lock"))

(c-lang-defconst c-simple-stmt-kwds
  csharp '("break" "continue" "goto" "return" "throw"))

(c-lang-defconst c-constant-kwds
  csharp  '("true" "false" "null" "value"))

(c-lang-defconst c-primary-expr-kwds
  csharp '("this" "base" "operator"))

(c-lang-defconst c-inexpr-class-kwds
  csharp nil)

(c-lang-defconst c-std-abbrev-keywords
  csharp (append (c-lang-const c-std-abbrev-keywords) '("catch" "finally")))

(c-lang-defconst c-decl-prefix-re
  csharp "\\([{}(;,<]+\\)")

(c-lang-defconst c-opt-type-suffix-key
  csharp (concat "\\(\\[" (c-lang-const c-simple-ws) "*\\]\\|\\.\\.\\.\\)"))

(c-lang-defconst c-recognize-typeless-decls
  csharp t)

(c-lang-defconst c-recognize-<>-arglists
  csharp t)

(c-lang-defconst c-opt-cpp-prefix
  csharp "#")

(c-add-style "csharp"
             '("java"
               (c-basic-offset . 4)
               (c-comment-only-line-offset . (0 . 0))
               (c-offsets-alist . ((inline-open . 0)
			           (topmost-intro         . 0)
                                   (topmost-intro-cont    . 0)
                                   (arglist-intro         . +)
                                   (arglist-close         . 0)
                                   (inexpr-class          . 0)
                                   (case-label            . +)
                                   (cpp-macro             . [0])
                                   (substatement-open     . 0)))))

(defcustom csharp-font-lock-extra-types
  (list (concat "[" c-upper "]\\sw*[" c-lower "]\\sw"))
  (c-make-font-lock-extra-types-blurb "C#" "csharp-mode" (concat))
  :type 'c-extra-types-widget
  :group 'c)

(defconst csharp-font-lock-keywords-1 (c-lang-const c-matchers-1 csharp)
  "Minimal font locking for C# mode.")

(defconst csharp-font-lock-keywords-2 (c-lang-const c-matchers-2 csharp)
  "Fast normal font locking for C# mode.")

(defconst csharp-font-lock-keywords-3 (c-lang-const c-matchers-3 csharp)
  "Accurate normal font locking for C# mode.")

(defvar csharp-font-lock-keywords csharp-font-lock-keywords-3
  "Default expressions to highlight in C# mode.")

(defun csharp-font-lock-keywords-2 ()
  (c-compose-keywords-list csharp-font-lock-keywords-2))
(defun csharp-font-lock-keywords-3 ()
  (c-compose-keywords-list csharp-font-lock-keywords-3))
(defun csharp-font-lock-keywords ()
  (c-compose-keywords-list csharp-font-lock-keywords))

;; Support for C#

(defvar csharp-mode-syntax-table
  (funcall (c-lang-const c-make-mode-syntax-table csharp))
  "Syntax table used in csharp-mode buffers.")

(defvar csharp-mode-map
  (let ((map (c-make-inherited-keymap)))
    map)
  "Keymap used in csharp-mode buffers.")

(easy-menu-define csharp-menu csharp-mode-map "C# Mode Commands"
  (cons "C#" (c-lang-const c-mode-menu csharp)))

;;;###autoload
(add-to-list 'auto-mode-alist '("\\.cs\\'" . csharp-mode))

;; Custom variables
;;;###autoload
(defcustom csharp-mode-hook nil
  "*Hook called by `csharp-mode'."
  :type 'hook
  :group 'csharp)

;;;###autoload
(define-derived-mode csharp-mode prog-mode "C#"
  "Major mode for editing Csharp code.

Key bindings:
\\{csharp-mode-map}"
  :after-hook (c-update-modeline)
  (c-initialize-cc-mode t)
  (c-init-language-vars csharp-mode)
  (c-common-init 'csharp-mode)
  (easy-menu-add csharp-menu)
  (c-set-style "csharp")
  (c-run-mode-hooks 'c-mode-common-hook 'csharp-mode-hook))

(provide 'csharp-mode)

;;; csharp-mode.el ends here
