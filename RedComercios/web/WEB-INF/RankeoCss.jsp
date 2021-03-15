 @import url('https://fonts.googleapis.com/css?family=Open+Sans&display=swap');
 @import url('https://fonts.googleapis.com/css2?family=Manrope:wght@200&display=swap');

 body {
     margin: 0;
     padding: 0;
     font-family: 'Open Sans', serif;
     background: #eee
 }

 .content {
     width: 420px;
     margin-top: 100px
 }

 .ratings {
     background-color: #fff;
     padding: 54px;
     border: 1px solid rgba(0, 0, 0, 0.1);
     box-shadow: 0px 10px 10px #E0E0E0
 }

 .product-rating {
     font-size: 50px
 }

 .stars i {
     font-size: 18px;
     color: #28a745
 }

 .rating-text {
     margin-top: 10px
 }

.comment-box {
    padding: 5px
}

.comment-area textarea {
    resize: none;
    border: 1px solid #ad9f9f
}

.form-control:focus {
    color: #495057;
    background-color: #fff;
    border-color: #ffffff;
    outline: 0;
    box-shadow: 0 0 0 1px rgb(255, 0, 0) !important
}

.send {
    color: #fff;
    background-color: #ff0000;
    border-color: #ff0000
}

.send:hover {
    color: #fff;
    background-color: #f50202;
    border-color: #f50202
}

.rating {
    display: flex;
    margin-top: -10px;
    flex-direction: row-reverse;
    margin-left: -4px;
    float: left
}

.rating>input {
    display: none
}

.rating>label {
    position: relative;
    width: 19px;
    font-size: 25px;
    color: #ff0000;
    cursor: pointer
}

.rating>label::before {
    content: "\2605";
    position: absolute;
    opacity: 0
}

.rating>label:hover:before,
.rating>label:hover~label:before {
    opacity: 1 !important
}

.rating>input:checked~label:before {
    opacity: 1
}

.rating:hover>input:checked~label:before {
    opacity: 0.4
}