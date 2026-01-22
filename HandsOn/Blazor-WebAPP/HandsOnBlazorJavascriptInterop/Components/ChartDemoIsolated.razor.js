import {
    Chart,
    BarController,
    BarElement,
    CategoryScale,
    LinearScale,
    Tooltip,
    Legend
} from "https://cdn.jsdelivr.net/npm/chart.js@4.4.0/dist/chart.esm.js";

/* 🔴 REQUIRED REGISTRATION */
Chart.register(
    BarController,
    BarElement,
    CategoryScale,
    LinearScale,
    Tooltip,
    Legend
);

export function createBarChart(canvas, labels, values) {

    console.log("Chart.js isolation invoked");

    return new Chart(canvas, {
        type: 'bar',
        data: {
            labels: labels,
            datasets: [{
                label: 'Sales',
                data: values,
                backgroundColor: 'rgba(54, 162, 235, 0.7)'
            }]
        },
        options: {
            responsive: false,
            animation: false
        }
    });
}
