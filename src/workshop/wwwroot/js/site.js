document.addEventListener("DOMContentLoaded", () => {
	const invalid = document.querySelector(".input-validation-error");
	if (invalid instanceof HTMLElement) {
		invalid.focus();
	}
});
