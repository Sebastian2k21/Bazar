$(document).ready(function () {
    $("#search_button").click(function () {
        let text = $("#search_text").val()
        let from = $("#price_from").val()
        let to = $("#price_to").val()

        let url = "/api/filter";
        let params = []
        if (text != null && text != "") {
            params.push("text=" + text);
        }
        if (from != null && from != "") {
            params.push("from=" + from);
        }
        if (to != null && to != "") {
            params.push("to=" + to);
        }
        params.forEach(x => {
            if (!url.includes("?")) {
                url += "?" + x;
            }
            else {
                url += "&" + x;
            }
        })
        $.get(url, function (data) {
            let table = $("#tableBody");
            table.html("")
            data.forEach(item => {
                let row = $("<tr></tr>")
                let col1 = $("<td></td>").append(`<a href='/Item/Details/${item.id}'>${item.name}</a>`)
                let col2 = $("<td></td>").append("" + item.price)
                row.append(col1, col2)
                table.append(row)
            });
            console.log(data)
        })
    })
})
