(require 'cc-mode)
(require 'cc-langs)

(eval-and-compile
  (c-add-language 'cblunt-mode 'c-mode))

(c-lang-defconst c-multiline-string-start-char
  cblunt ?@)

(defvar cblunt-font-lock-keywords-3 nil)

;;;###autoload
(add-to-list 'auto-mode-alist '("\\.cs\\'" . cblunt-mode))

;;;###autoload
(define-derived-mode cblunt-mode prog-mode "CB"
  ""
  :after-hook (c-update-modeline)
  (c-initialize-cc-mode t)
  (c-init-language-vars cblunt-mode)
  (c-common-init 'cblunt-mode)
  (c-run-mode-hooks 'c-mode-common-hook 'cblunt-mode-hook))

(provide 'cblunt-mode)
