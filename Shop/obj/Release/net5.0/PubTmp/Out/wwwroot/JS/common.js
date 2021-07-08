function modalState(modalName, state) {
    $(modalName).modal(state)

}


function playSound(src) {
    var audio = new Audio(src);
    audio.play();
}


function ImageDetailsSlider() {
    $(document).ready(function () {
        $('.product-image-details').slick({
            slidesToShow: 1,
            dots: true,
            centerMode: false,
            autoplay: true,
        });
    });
}



function headerSlider() {
    $(document).ready(function () {

        $('.carousel').slick({
            slidesToShow: 1,
            dots: false,
            centerMode: false,
            autoplay: true,
        });
    });
}


function Pay(amount,description,callbackurl) {
    Moyasar.init({
        // Required
        // Specify where to render the form
        // Can be a valid CSS selector and a reference to a DOM element
        element: '.mysr-form',

        // Required
        // Amount in the smallest currency unit
        // For example:
        // 10 SAR = 10 * 100 Halalas
        // 10 KWD = 10 * 1000 Fils
        // 10 JPY = 10 JPY (Japanese Yen does not have fractions)
        amount: amount,

        // Required
        // Currency of the payment transation
        currency: 'SAR',

        // Required
        // A small description of the current payment process
        description: description,

        // Required
        publishable_api_key: 'pk_test_LtYJwNzgm9okYdM1rktpNktg7wqSqCJN1ajkKexr',

        // Required
        // This URL is used to redirect the user when payment process has completed
        // Payment can be either a success or a failure, which you need to verify on you system (We will show this in a couple of lines)
        callback_url: callbackurl,

        language: 'ar', 

        // Optional
        // Required payments methods
        // Default: ['creditcard', 'applepay', 'stcpay']
        methods: [
            'creditcard',
        ],
    });

}




//window.addEventListener("scroll", () => {
//    var header = document.querySelector("header");

//    if (window.scrollY > 0) {
//        header.classList.add("sticky");
//    }
//    if (window.scrollY == 0) {
//        header.classList.remove("sticky");
//    }
//});

