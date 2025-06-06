document.addEventListener("DOMContentLoaded", function () {
    const estadoSelect = document.getElementById("estado");
    estadoSelect.addEventListener("change", function () {
        this.form.submit();
    });
});