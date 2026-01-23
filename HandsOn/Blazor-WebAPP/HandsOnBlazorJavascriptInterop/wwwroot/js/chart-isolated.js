import {
    Chart,
    BarController,
    BarElement,
    CategoryScale,
    LinearScale
} from "https://cdn.jsdelivr.net/npm/chart.js@4.4.0/dist/chart.esm.js";

/* 🔴 REQUIRED in Chart.js v4 */
Chart.register(
    BarController,
    BarElement,
    CategoryScale,
    LinearScale
);

console.log("✅ chart-isolated.js loaded");

export function renderBarChart(canvas) {

    console.log("✅ renderBarChart called");

    new Chart(canvas, {
        type: 'bar',
        data: {
            labels: ["Jan", "Feb", "Mar", "Apr"],
            datasets: [{
                label: "Sales",
                data: [10, 25, 15, 30],
                backgroundColor: "rgba(54, 162, 235, 0.7)"
            }]
        },
        options: {
            responsive: false,
            animation: false
        }
    });
}
