// get counter paragraph element from dom
const doc_visitor_count = document.querySelector("#counter p");

// send a post request to Azure Function
fetch("https://austinsresumefunction.azurewebsites.net/api/httpexample", {
    method: "POST",
    headers: {
        "Accept": "application/json",
    }
}).then(
    // Get response and parse JSON data
    res => res.json()
).then(data => {
    // change html element's content to the `count` property of the response
    // data
    doc_visitor_count.innerHTML = data.count.toString()
})
