window.createBarChart = function (canvasId, labels, dataValues) {

    console.log("createBarChart called");

    const canvas = document.getElementById(canvasId);

    if (!canvas) {
        console.error("Canvas not found:", canvasId);
        return;
    }

    new Chart(canvas, {          // ✅ IMPORTANT CHANGE
        type: 'bar',
        data: {
            labels: labels,
            datasets: [{
                label: 'Sales',
                data: dataValues,
                backgroundColor: 'rgba(54, 162, 235, 0.6)'
            }]
        },
        options: {
            responsive: false,
            animation: false
        }
    });
};
