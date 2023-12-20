const doc_visitor_count = document.querySelector("#counter p");
const canvas = document.querySelector("canvas");

fetch("https://austinsresumefunction.azurewebsites.net/api/httpexample", {
    method: "POST",
    headers: {
        "Accept": "application/json",
    }
}).then(
    res => res.json()
).then(data => {
    doc_visitor_count.innerHTML = data.count.toString()
})
