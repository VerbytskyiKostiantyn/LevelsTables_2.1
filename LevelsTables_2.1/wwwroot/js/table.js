
const searchInput = document.getElementById('search');
const closeButton = document.getElementById('closeButton');
const closeButtonCross = document.getElementById('closeButtonCross');
//const buttons = document.querySelectorAll('.hidden-xs .btn');
const baseButtons = document.querySelectorAll('.hidden-xs .btn');
const dropdownButtons = document.querySelectorAll('.dropdown.visible-xs .dropdown-menu .btn');
const buttons = [...baseButtons, ...dropdownButtons];


const tableWrappers = document.querySelectorAll('.table-container > .table-wrapper');
let isFiltered = false;
let buttonFilterValue = '';
let previouslySelectedButton = null;
let targetButton = null;

const sortedTableWrappers = Array.prototype.slice.call(tableWrappers).sort((a, b) => {
    const stationNameA = a.querySelector('table.tg > tbody > tr > td[colspan="5"]').textContent.trim().toLowerCase();
    const stationNameB = b.querySelector('table.tg > tbody > tr > td[colspan="5"]').textContent.trim().toLowerCase();
    return stationNameA.localeCompare(stationNameB);
});

const tableContainer = tableWrappers[0].parentNode;
tableContainer.innerHTML = '';
sortedTableWrappers.forEach((tableWrapper) => {
    tableContainer.appendChild(tableWrapper);
});

searchInput.addEventListener('input', () => {
    const searchText = searchInput.value.trim().toLowerCase();
    filterTableWrappers(searchText, buttonFilterValue);
});

buttons.forEach(button => {
    button.addEventListener('click', () => {
        const condition = button.value;
        buttonFilterValue = condition;

        if ((previouslySelectedButton == button) && (previouslySelectedButton && isFiltered)) {
            isFiltered = false;
            //button.style.backgroundColor = '#7ad8fa';
            buttonFilterValue = '';
            closeButton.style.display = 'none';
            closeButtonCross.style.display = 'none';

            getButtonByInnerText(button, baseButtons).style.backgroundColor = '#7ad8fa';
            getButtonByInnerText(button, dropdownButtons).style.backgroundColor = '#7ad8fa';

        } else if (previouslySelectedButton && isFiltered) {
            //previouslySelectedButton.style.backgroundColor = '#7ad8fa';
            //button.style.backgroundColor = '#fa7a7a';
            closeButton.innerText = button.innerText;

            getButtonByInnerText(previouslySelectedButton, baseButtons).style.backgroundColor = '#7ad8fa';
            getButtonByInnerText(previouslySelectedButton, dropdownButtons).style.backgroundColor = '#7ad8fa';

            getButtonByInnerText(button, baseButtons).style.backgroundColor = '#fa7a7a';
            getButtonByInnerText(button, dropdownButtons).style.backgroundColor = '#fa7a7a';
        }
        else {
            isFiltered = true;
            //button.style.backgroundColor = '#fa7a7a';
            closeButton.innerText = button.innerText;
            closeButton.style.display = 'inline-flex';
            closeButtonCross.style.display = 'inline-flex';

            getButtonByInnerText(button, baseButtons).style.backgroundColor = '#fa7a7a';
            getButtonByInnerText(button, dropdownButtons).style.backgroundColor = '#fa7a7a';
        }

        previouslySelectedButton = button;

        filterTableWrappers(searchInput.value.trim().toLowerCase(), buttonFilterValue);
    });
});
closeButtonCross.addEventListener("click", function (event) {
    isFiltered = false;
    getButtonByInnerText(previouslySelectedButton, baseButtons).style.backgroundColor = '#7ad8fa';
    getButtonByInnerText(previouslySelectedButton, dropdownButtons).style.backgroundColor = '#7ad8fa';
    closeButton.style.display = 'none';
    closeButtonCross.style.display = 'none';
    filterTableWrappers(searchInput.value.trim().toLowerCase(), '');
});

function getButtonByInnerText(originalButton, selectButtons) {
    for (let selectButton of selectButtons) {
        if (selectButton.innerText.trim() === originalButton.innerText.trim()) {
            return selectButton;
        }
    };
}
function filterTableWrappers(searchText, buttonFilterValue) {
    tableWrappers.forEach((tableWrapper) => {
        tableWrapper.style.display = 'none';
    });

    const filteredTableWrappers = Array.prototype.slice.call(tableWrappers).filter((tableWrapper) => {
        const tableName = tableWrapper.querySelector('table.tg > tbody > tr > td[colspan="5"]').textContent.trim().toLowerCase();
        if (buttonFilterValue && searchText) {
            return tableName.includes(buttonFilterValue) && tableName.includes(searchText);
        } else if (buttonFilterValue) {
            return tableName.includes(buttonFilterValue);
        } else if (searchText) {
            return tableName.includes(searchText);
        } else {
            return true;
        }
    });

    filteredTableWrappers.forEach((tableWrapper) => {
        tableWrapper.style.display = 'block';
    });
}


document.querySelectorAll('.table-row').forEach(function (row) {
    row.addEventListener('click', function () {
        var modalId = this.getAttribute('data-modal-id');
        var modal = document.getElementById(modalId);

        modal.style.display = 'block';
        document.body.style.overflow = 'hidden';


        modal.addEventListener('click', (event) => {
            if (event.target === modal) {
                modal.style.display = 'none';
                document.body.style.overflow = ''; 
            }
        });

        var closeModalButtons = document.querySelectorAll('.close');
        closeModalButtons.forEach(function (closeModalButton) {
            closeModalButton.addEventListener('click', () => {
                modal.style.display = 'none';
                document.body.style.overflow = 'auto'; 
            });
        });
    });
});

