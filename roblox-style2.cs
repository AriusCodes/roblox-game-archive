@import url(https://fonts.googleapis.com/css?family=Jost:100,200,300,400,500,600,700,800,900,100i,200i,300i,400i,500i,600i,700i,800i,900i&display=swap);





body {
  font-family: Jost;
}
.display-1 {
  font-family: 'Jost', sans-serif;
  font-size: 5.5rem;
  line-height: 1.2;
}
.display-1 > .mbr-iconfont {
  font-size: 8.8rem;
}
.display-2 {
  font-family: 'Jost', sans-serif;
  font-size: 2.8rem;
  line-height: 1.4;
}
.display-2 > .mbr-iconfont {
  font-size: 4.48rem;
}
.display-4 {
  font-family: 'Jost', sans-serif;
  font-size: 1rem;
  line-height: 1.3;
}
.display-4 > .mbr-iconfont {
  font-size: 1.6rem;
}
.display-5 {
  font-family: 'Jost', sans-serif;
  font-size: 1.6rem;
  line-height: 1.4;
}
.display-5 > .mbr-iconfont {
  font-size: 2.56rem;
}
.display-7 {
  font-family: 'Jost', sans-serif;
  font-size: 1.2rem;
  line-height: 1.4;
}
.display-7 > .mbr-iconfont {
  font-size: 1.92rem;
}
/* ---- Fluid typography for mobile devices ---- */
/* 1.4 - font scale ratio ( bootstrap == 1.42857 ) */
/* 100vw - current viewport width */
/* (48 - 20)  48 == 48rem == 768px, 20 == 20rem == 320px(minimal supported viewport) */
/* 0.65 - min scale variable, may vary */
@media (max-width: 768px) {
  .display-1 {
    font-size: 3.85rem;
    font-size: calc( 2.5749999999999997rem + (5.5 - 2.5749999999999997) * ((100vw - 20rem) / (48 - 20)));
    line-height: calc( 1.1 * (2.5749999999999997rem + (5.5 - 2.5749999999999997) * ((100vw - 20rem) / (48 - 20))));
  }
  .display-2 {
    font-size: 2.24rem;
    font-size: calc( 1.63rem + (2.8 - 1.63) * ((100vw - 20rem) / (48 - 20)));
    line-height: calc( 1.3 * (1.63rem + (2.8 - 1.63) * ((100vw - 20rem) / (48 - 20))));
  }
  .display-4 {
    font-size: 0.9rem !important;
    font-size: calc( 1rem + (1 - 1) * ((100vw - 20rem) / (48 - 20)));
    line-height: calc( 1.4 * (1rem + (1 - 1) * ((100vw - 20rem) / (48 - 20))));
  }
  .display-5 {
    font-size: 1.28rem;
    font-size: calc( 1.21rem + (1.6 - 1.21) * ((100vw - 20rem) / (48 - 20)));
    line-height: calc( 1.4 * (1.21rem + (1.6 - 1.21) * ((100vw - 20rem) / (48 - 20))));
  }
  .display-7 {
    font-size: 0.96rem;
    font-size: calc( 1.07rem + (1.2 - 1.07) * ((100vw - 20rem) / (48 - 20)));
    line-height: calc( 1.4 * (1.07rem + (1.2 - 1.07) * ((100vw - 20rem) / (48 - 20))));
  }
}
/* Buttons */
.btn {
  padding: 1rem 3rem;
  border-radius: 4px;
}
.btn-sm {
  padding: 0.6rem 1.2rem;
  border-radius: 4px;
}
.btn-md {
  padding: 1rem 2.6rem;
  border-radius: 8px;
}
.btn-lg {
  padding: 1.2rem 3.2rem;
  border-radius: 8px;
}
.bg-primary {
  background-color: #5758e0 !important;
}
.bg-success {
  background-color: #5758e0 !important;
}
.bg-info {
  background-color: #82786e !important;
}
.bg-warning {
  background-color: #5b686b !important;
}
.bg-danger {
  background-color: #465052 !important;
}
.btn-primary,
.btn-primary:active {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
  color: #ffffff !important;
}
.btn-primary:hover,
.btn-primary:focus,
.btn-primary.focus,
.btn-primary.active {
  color: #ffffff !important;
  background-color: #2526c6 !important;
  border-color: #2526c6 !important;
}
.btn-primary.disabled,
.btn-primary:disabled {
  color: #ffffff !important;
  background-color: #2526c6 !important;
  border-color: #2526c6 !important;
}
.btn-primary:hover {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-primary:hover,
.btn-primary:focus {
  background: linear-gradient(to left, #55b4d4, #5758e0);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-secondary,
.btn-secondary:active {
  background-color: #55b4d4 !important;
  border-color: #55b4d4 !important;
  color: #ffffff !important;
}
.btn-secondary:hover,
.btn-secondary:focus,
.btn-secondary.focus,
.btn-secondary.active {
  color: #ffffff !important;
  background-color: #2d8fb0 !important;
  border-color: #2d8fb0 !important;
}
.btn-secondary.disabled,
.btn-secondary:disabled {
  color: #ffffff !important;
  background-color: #2d8fb0 !important;
  border-color: #2d8fb0 !important;
}
.btn-secondary:hover {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-secondary:hover,
.btn-secondary:focus {
  background: linear-gradient(to left, #55b4d4, #55b4d4);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-info,
.btn-info:active {
  background-color: #82786e !important;
  border-color: #82786e !important;
  color: #ffffff !important;
}
.btn-info:hover,
.btn-info:focus,
.btn-info.focus,
.btn-info.active {
  color: #ffffff !important;
  background-color: #59524b !important;
  border-color: #59524b !important;
}
.btn-info.disabled,
.btn-info:disabled {
  color: #ffffff !important;
  background-color: #59524b !important;
  border-color: #59524b !important;
}
.btn-info:hover {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-info:hover,
.btn-info:focus {
  background: linear-gradient(to left, #55b4d4, #82786e);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-success,
.btn-success:active {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
  color: #ffffff !important;
}
.btn-success:hover,
.btn-success:focus,
.btn-success.focus,
.btn-success.active {
  color: #ffffff !important;
  background-color: #2526c6 !important;
  border-color: #2526c6 !important;
}
.btn-success.disabled,
.btn-success:disabled {
  color: #ffffff !important;
  background-color: #2526c6 !important;
  border-color: #2526c6 !important;
}
.btn-success:hover {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-success:hover,
.btn-success:focus {
  background: linear-gradient(to left, #55b4d4, #5758e0);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-warning,
.btn-warning:active {
  background-color: #5b686b !important;
  border-color: #5b686b !important;
  color: #ffffff !important;
}
.btn-warning:hover,
.btn-warning:focus,
.btn-warning.focus,
.btn-warning.active {
  color: #ffffff !important;
  background-color: #384042 !important;
  border-color: #384042 !important;
}
.btn-warning.disabled,
.btn-warning:disabled {
  color: #ffffff !important;
  background-color: #384042 !important;
  border-color: #384042 !important;
}
.btn-warning:hover {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-warning:hover,
.btn-warning:focus {
  background: linear-gradient(to left, #55b4d4, #5b686b);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-danger,
.btn-danger:active {
  background-color: #465052 !important;
  border-color: #465052 !important;
  color: #ffffff !important;
}
.btn-danger:hover,
.btn-danger:focus,
.btn-danger.focus,
.btn-danger.active {
  color: #ffffff !important;
  background-color: #232829 !important;
  border-color: #232829 !important;
}
.btn-danger.disabled,
.btn-danger:disabled {
  color: #ffffff !important;
  background-color: #232829 !important;
  border-color: #232829 !important;
}
.btn-danger:hover {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-danger:hover,
.btn-danger:focus {
  background: linear-gradient(to left, #55b4d4, #465052);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-white,
.btn-white:active {
  background-color: #f3f3f3 !important;
  border-color: #f3f3f3 !important;
  color: #737373 !important;
}
.btn-white:hover,
.btn-white:focus,
.btn-white.focus,
.btn-white.active {
  color: #737373 !important;
  background-color: #cdcdcd !important;
  border-color: #cdcdcd !important;
}
.btn-white.disabled,
.btn-white:disabled {
  color: #737373 !important;
  background-color: #cdcdcd !important;
  border-color: #cdcdcd !important;
}
.btn-white:hover {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-white:hover,
.btn-white:focus {
  background: linear-gradient(to left, #55b4d4, #f3f3f3);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-white:hover {
  color: white!important;
}
.btn-black,
.btn-black:active {
  background-color: #000000 !important;
  border-color: #000000 !important;
  color: #ffffff !important;
}
.btn-black:hover,
.btn-black:focus,
.btn-black.focus,
.btn-black.active {
  color: #ffffff !important;
  background-color: #000000 !important;
  border-color: #000000 !important;
}
.btn-black.disabled,
.btn-black:disabled {
  color: #ffffff !important;
  background-color: #000000 !important;
  border-color: #000000 !important;
}
.btn-black:hover {
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-black:hover,
.btn-black:focus {
  background: linear-gradient(to left, #55b4d4, #000000);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-primary-outline {
  color: white!important;
}
.btn-primary-outline,
.btn-primary-outline:active {
  background: none;
  border-color: #5758e0;
  color: #5758e0;
}
.btn-primary-outline:hover,
.btn-primary-outline:focus,
.btn-primary-outline.focus,
.btn-primary-outline.active {
  color: #ffffff;
  background-color: #5758e0;
  border-color: #5758e0;
}
.btn-primary-outline.disabled,
.btn-primary-outline:disabled {
  color: #ffffff !important;
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-primary-outline:hover,
.btn-primary-outline:focus {
  background: linear-gradient(to left, #55b4d4, #5758e0);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-secondary-outline {
  color: white!important;
}
.btn-secondary-outline,
.btn-secondary-outline:active {
  background: none;
  border-color: #55b4d4;
  color: #55b4d4;
}
.btn-secondary-outline:hover,
.btn-secondary-outline:focus,
.btn-secondary-outline.focus,
.btn-secondary-outline.active {
  color: #ffffff;
  background-color: #55b4d4;
  border-color: #55b4d4;
}
.btn-secondary-outline.disabled,
.btn-secondary-outline:disabled {
  color: #ffffff !important;
  background-color: #55b4d4 !important;
  border-color: #55b4d4 !important;
}
.btn-secondary-outline:hover,
.btn-secondary-outline:focus {
  background: linear-gradient(to left, #55b4d4, #55b4d4);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-info-outline {
  color: white!important;
}
.btn-info-outline,
.btn-info-outline:active {
  background: none;
  border-color: #82786e;
  color: #82786e;
}
.btn-info-outline:hover,
.btn-info-outline:focus,
.btn-info-outline.focus,
.btn-info-outline.active {
  color: #ffffff;
  background-color: #82786e;
  border-color: #82786e;
}
.btn-info-outline.disabled,
.btn-info-outline:disabled {
  color: #ffffff !important;
  background-color: #82786e !important;
  border-color: #82786e !important;
}
.btn-info-outline:hover,
.btn-info-outline:focus {
  background: linear-gradient(to left, #55b4d4, #82786e);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-success-outline {
  color: white!important;
}
.btn-success-outline,
.btn-success-outline:active {
  background: none;
  border-color: #5758e0;
  color: #5758e0;
}
.btn-success-outline:hover,
.btn-success-outline:focus,
.btn-success-outline.focus,
.btn-success-outline.active {
  color: #ffffff;
  background-color: #5758e0;
  border-color: #5758e0;
}
.btn-success-outline.disabled,
.btn-success-outline:disabled {
  color: #ffffff !important;
  background-color: #5758e0 !important;
  border-color: #5758e0 !important;
}
.btn-success-outline:hover,
.btn-success-outline:focus {
  background: linear-gradient(to left, #55b4d4, #5758e0);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-warning-outline {
  color: white!important;
}
.btn-warning-outline,
.btn-warning-outline:active {
  background: none;
  border-color: #5b686b;
  color: #5b686b;
}
.btn-warning-outline:hover,
.btn-warning-outline:focus,
.btn-warning-outline.focus,
.btn-warning-outline.active {
  color: #ffffff;
  background-color: #5b686b;
  border-color: #5b686b;
}
.btn-warning-outline.disabled,
.btn-warning-outline:disabled {
  color: #ffffff !important;
  background-color: #5b686b !important;
  border-color: #5b686b !important;
}
.btn-warning-outline:hover,
.btn-warning-outline:focus {
  background: linear-gradient(to left, #55b4d4, #5b686b);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-danger-outline {
  color: white!important;
}
.btn-danger-outline,
.btn-danger-outline:active {
  background: none;
  border-color: #465052;
  color: #465052;
}
.btn-danger-outline:hover,
.btn-danger-outline:focus,
.btn-danger-outline.focus,
.btn-danger-outline.active {
  color: #ffffff;
  background-color: #465052;
  border-color: #465052;
}
.btn-danger-outline.disabled,
.btn-danger-outline:disabled {
  color: #ffffff !important;
  background-color: #465052 !important;
  border-color: #465052 !important;
}
.btn-danger-outline:hover,
.btn-danger-outline:focus {
  background: linear-gradient(to left, #55b4d4, #465052);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-black-outline {
  color: white!important;
}
.btn-black-outline,
.btn-black-outline:active {
  background: none;
  border-color: #333333;
  color: #333333;
}
.btn-black-outline:hover,
.btn-black-outline:focus,
.btn-black-outline.focus,
.btn-black-outline.active {
  color: #ffffff;
  background-color: #333333;
  border-color: #333333;
}
.btn-black-outline.disabled,
.btn-black-outline:disabled {
  color: #ffffff !important;
  background-color: #333333 !important;
  border-color: #333333 !important;
}
.btn-black-outline:hover,
.btn-black-outline:focus {
  background: linear-gradient(to left, #55b4d4, #333333);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.btn-white-outline {
  color: white!important;
}
.btn-white-outline,
.btn-white-outline:active {
  background: none;
  border-color: #f3f3f3;
  color: #f3f3f3;
}
.btn-white-outline:hover,
.btn-white-outline:focus,
.btn-white-outline.focus,
.btn-white-outline.active {
  color: #737373;
  background-color: #f3f3f3;
  border-color: #f3f3f3;
}
.btn-white-outline.disabled,
.btn-white-outline:disabled {
  color: #737373 !important;
  background-color: #f3f3f3 !important;
  border-color: #f3f3f3 !important;
}
.btn-white-outline:hover,
.btn-white-outline:focus {
  background: linear-gradient(to left, #55b4d4, #f3f3f3);
  border-color: transparent!important;
  background-size: 110%;
  background-position: center;
}
.text-primary {
  color: #5758e0 !important;
}
.text-secondary {
  color: #55b4d4 !important;
}
.text-success {
  color: #5758e0 !important;
}
.text-info {
  color: #82786e !important;
}
.text-warning {
  color: #5b686b !important;
}
.text-danger {
  color: #465052 !important;
}
.text-white {
  color: #ffffff !important;
}
.text-black {
  color: #000000 !important;
}
a.text-primary:hover,
a.text-primary:focus {
  color: #adaef0 !important;
}
a.text-secondary:hover,
a.text-secondary:focus {
  color: #a6d8e9 !important;
}
a.text-success:hover,
a.text-success:focus {
  color: #adaef0 !important;
}
a.text-info:hover,
a.text-info:focus {
  color: #b2aba4 !important;
}
a.text-warning:hover,
a.text-warning:focus {
  color: #8e9b9e !important;
}
a.text-danger:hover,
a.text-danger:focus {
  color: #758689 !important;
}
a.text-white:hover,
a.text-white:focus {
  color: #ffffff !important;
}
a.text-black:hover,
a.text-black:focus {
  color: #4d4d4d !important;
}
.alert-success {
  background-color: #70c770;
}
.alert-info {
  background-color: #82786e;
}
.alert-warning {
  background-color: #5b686b;
}
.alert-danger {
  background-color: #465052;
}
.mbr-gallery-filter li.active .btn {
  background-color: #5758e0;
  border-color: #5758e0;
  color: #ffffff;
}
.mbr-gallery-filter li.active .btn:focus {
  box-shadow: none;
}
a,
a:hover {
  color: #5758e0;
}
.mbr-plan-header.bg-primary .mbr-plan-subtitle,
.mbr-plan-header.bg-primary .mbr-plan-price-desc {
  color: #ffffff;
}
.mbr-plan-header.bg-success .mbr-plan-subtitle,
.mbr-plan-header.bg-success .mbr-plan-price-desc {
  color: #ffffff;
}
.mbr-plan-header.bg-info .mbr-plan-subtitle,
.mbr-plan-header.bg-info .mbr-plan-price-desc {
  color: #beb8b2;
}
.mbr-plan-header.bg-warning .mbr-plan-subtitle,
.mbr-plan-header.bg-warning .mbr-plan-price-desc {
  color: #9ba7aa;
}
.mbr-plan-header.bg-danger .mbr-plan-subtitle,
.mbr-plan-header.bg-danger .mbr-plan-price-desc {
  color: #bac2c4;
}
/* Scroll to top button*/
.scrollToTop_wraper {
  display: none;
}
blockquote {
  border-color: #5758e0;
}
/* Forms */
.mbr-form .btn {
  margin: .4rem 0;
}
.jq-selectbox li:hover,
.jq-selectbox li.selected {
  background-color: #5758e0;
  color: #ffffff;
}
.jq-selectbox .jq-selectbox__trigger-arrow,
.jq-number__spin.minus:after,
.jq-number__spin.plus:after {
  transition: 0.4s;
  border-top-color: gray !important;
  border-bottom-color: gray !important;
}
.jq-selectbox:hover .jq-selectbox__trigger-arrow,
.jq-number__spin.minus:hover:after,
.jq-number__spin.plus:hover:after {
  border-top-color: #5758e0;
  border-bottom-color: #5758e0;
}
.xdsoft_datetimepicker .xdsoft_calendar td.xdsoft_default,
.xdsoft_datetimepicker .xdsoft_calendar td.xdsoft_current,
.xdsoft_datetimepicker .xdsoft_timepicker .xdsoft_time_box > div > div.xdsoft_current {
  color: #ffffff !important;
  background-color: #5758e0 !important;
  box-shadow: none !important;
}
.xdsoft_datetimepicker .xdsoft_calendar td:hover,
.xdsoft_datetimepicker .xdsoft_timepicker .xdsoft_time_box > div > div:hover {
  color: #000000 !important;
  background: #55b4d4 !important;
  box-shadow: none !important;
}
.lazy-bg {
  background-image: none !important;
}
.lazy-placeholder:not(section),
.lazy-none {
  display: block;
  position: relative;
  padding-bottom: 56.25%;
  width: 100%;
  height: auto;
}
iframe.lazy-placeholder,
.lazy-placeholder:after {
  content: '';
  position: absolute;
  width: 200px;
  height: 200px;
  background: transparent no-repeat center;
  background-size: contain;
  top: 50%;
  left: 50%;
  transform: translateX(-50%) translateY(-50%);
  background-image: url("data:image/svg+xml;charset=UTF-8,%3csvg width='32' height='32' viewBox='0 0 64 64' xmlns='http://www.w3.org/2000/svg' stroke='%235758e0' %3e%3cg fill='none' fill-rule='evenodd'%3e%3cg transform='translate(16 16)' stroke-width='2'%3e%3ccircle stroke-opacity='.5' cx='16' cy='16' r='16'/%3e%3cpath d='M32 16c0-9.94-8.06-16-16-16'%3e%3canimateTransform attributeName='transform' type='rotate' from='0 16 16' to='360 16 16' dur='1s' repeatCount='indefinite'/%3e%3c/path%3e%3c/g%3e%3c/g%3e%3c/svg%3e");
}
section.lazy-placeholder:after {
  opacity: 0.5;
}
body {
  overflow-x: hidden;
}
a {
  transition: color 0.6s;
}
.btn {
  transition: none;
}
.cid-s1YNw91RvB .dropdown-item:before {
  font-family: MobiriseIcons !important;
  content: '\e966';
  display: inline-block;
  width: 0;
  position: absolute;
  left: 1rem;
  top: 0.5rem;
  margin-right: 0.5rem;
  line-height: 1;
  font-size: inherit;
  vertical-align: middle;
  text-align: center;
  overflow: hidden;
  -webkit-transform: scale(0, 1);
  transform: scale(0, 1);
  -webkit-transition: all 0.25s ease-in-out;
  -moz-transition: all 0.25s ease-in-out;
  transition: all 0.25s ease-in-out;
}
.cid-s1YNw91RvB .btn {
  white-space: nowrap;
}
.cid-s1YNw91RvB .nav-link,
.cid-s1YNw91RvB .icons-menu .mbr-iconfont,
.cid-s1YNw91RvB .dropdown-item {
  transition: all 0.1s;
}
.cid-s1YNw91RvB .nav-link:hover,
.cid-s1YNw91RvB .icons-menu .mbr-iconfont:hover,
.cid-s1YNw91RvB .dropdown-item:hover {
  color: #55b4d4 !important;
}
@media (max-width: 992px) {
  .cid-s1YNw91RvB .icons-menu {
    padding: 1rem 0!important;
  }
}
.cid-s1YNw91RvB .container {
  display: flex;
  margin: auto;
}
.cid-s1YNw91RvB .navbar {
  box-shadow: 0 8px 20px 0 rgba(0, 0, 0, 0.1);
  min-height: 77px;
  transition: all .3s;
  background: #040402;
}
.cid-s1YNw91RvB .navbar.opened {
  transition: all .3s;
}
.cid-s1YNw91RvB .navbar .dropdown-item {
  padding: .5rem 1.8rem;
}
.cid-s1YNw91RvB .navbar .navbar-collapse {
  justify-content: space-between;
  z-index: 1;
}
.cid-s1YNw91RvB .navbar.collapsed .nav-item .nav-link::before {
  display: none;
}
.cid-s1YNw91RvB .navbar.collapsed.opened .dropdown-menu {
  top: 0;
}
.cid-s1YNw91RvB .navbar.collapsed .dropdown-menu .dropdown-submenu {
  left: 0 !important;
}
.cid-s1YNw91RvB .navbar.collapsed .dropdown-menu .dropdown-item:after {
  right: auto;
}
.cid-s1YNw91RvB .navbar.collapsed .dropdown-menu .dropdown-toggle[data-toggle="dropdown-submenu"]:after {
  margin-left: 0.5rem;
  margin-top: 0.2rem;
  border-top: 0.35em solid;
  border-right: 0.35em solid transparent;
  border-left: 0.35em solid transparent;
  border-bottom: 0;
  top: 55%;
}
.cid-s1YNw91RvB .navbar.collapsed ul.navbar-nav li {
  margin: auto;
}
.cid-s1YNw91RvB .navbar.collapsed .dropdown-menu .dropdown-item {
  padding: .25rem 1.5rem;
  text-align: center;
}
.cid-s1YNw91RvB .navbar.collapsed .icons-menu {
  padding-left: 0;
  padding-right: 0;
  padding-top: .5rem;
  padding-bottom: .5rem;
}
@media (max-width: 991px) {
  .cid-s1YNw91RvB .navbar .nav-item .nav-link::before {
    display: none;
  }
  .cid-s1YNw91RvB .navbar.opened .dropdown-menu {
    top: 0;
  }
  .cid-s1YNw91RvB .navbar .dropdown-menu .dropdown-submenu {
    left: 0 !important;
  }
  .cid-s1YNw91RvB .navbar .dropdown-menu .dropdown-item:after {
    right: auto;
  }
  .cid-s1YNw91RvB .navbar .dropdown-menu .dropdown-toggle[data-toggle="dropdown-submenu"]:after {
    margin-left: 0.5rem;
    margin-top: 0.2rem;
    border-top: 0.35em solid;
    border-right: 0.35em solid transparent;
    border-left: 0.35em solid transparent;
    border-bottom: 0;
    top: 55%;
  }
  .cid-s1YNw91RvB .navbar .navbar-logo img {
    height: 3.8rem !important;
  }
  .cid-s1YNw91RvB .navbar ul.navbar-nav li {
    margin: auto;
  }
  .cid-s1YNw91RvB .navbar .dropdown-menu .dropdown-item {
    padding: .25rem 1.5rem !important;
    text-align: center;
  }
  .cid-s1YNw91RvB .navbar .navbar-brand {
    -webkit-flex-shrink: initial;
    flex-shrink: initial;
    -webkit-flex-basis: auto;
    flex-basis: auto;
    word-break: break-word;
    padding-right: 2rem;
  }
  .cid-s1YNw91RvB .navbar .navbar-toggler {
    -webkit-flex-basis: auto;
    flex-basis: auto;
  }
  .cid-s1YNw91RvB .navbar .icons-menu {
    padding-left: 0;
    padding-top: .5rem;
    padding-bottom: .5rem;
  }
}
.cid-s1YNw91RvB .navbar.navbar-short {
  background: #040402 !important;
  min-height: 60px;
}
.cid-s1YNw91RvB .navbar.navbar-short .navbar-logo img {
  height: 3rem !important;
}
.cid-s1YNw91RvB .navbar.navbar-short .navbar-brand {
  padding: 0;
}
.cid-s1YNw91RvB .dropdown-menu {
  box-shadow: 0 8px 20px 0 rgba(0, 0, 0, 0.1);
  padding: 1rem 0;
}
.cid-s1YNw91RvB .nav-dropdown .link {
  padding: 0.4rem 1rem!important;
  margin: .2em 0.5rem;
}
.cid-s1YNw91RvB .nav-dropdown .link.dropdown-toggle::after {
  margin-left: 0.5rem;
  margin-top: 0.2rem;
}
.cid-s1YNw91RvB .mbr-iconfont {
  color: #ffffff !important;
  font-size: 1.5rem;
  padding-right: .5rem;
}
.cid-s1YNw91RvB .navbar-caption {
  padding-right: 4rem;
}
.cid-s1YNw91RvB .navbar-nav {
  justify-content: flex-end;
  width: -webkit-fill-available;
}
.cid-s1YNw91RvB .dropdown-menu,
.cid-s1YNw91RvB .navbar.opened {
  background: #191919 !important;
}
.cid-s1YNw91RvB .nav-item:focus,
.cid-s1YNw91RvB .nav-link:focus {
  outline: none;
}
.cid-s1YNw91RvB .dropdown .dropdown-menu .dropdown-item {
  width: auto;
  -webkit-transition: all 0.25s ease-in-out;
  -moz-transition: all 0.25s ease-in-out;
  transition: all 0.25s ease-in-out;
}
.cid-s1YNw91RvB .dropdown .dropdown-menu .dropdown-item::after {
  right: 0.5rem;
}
.cid-s1YNw91RvB .dropdown .dropdown-menu .dropdown-item .mbr-iconfont {
  margin-left: -1.8rem;
  padding-right: 1rem;
  font-size: inherit;
}
.cid-s1YNw91RvB .dropdown .dropdown-menu .dropdown-item .mbr-iconfont:before {
  display: inline-block;
  -webkit-transform: scale(1, 1);
  transform: scale(1, 1);
  -webkit-transition: all 0.25s ease-in-out;
  -moz-transition: all 0.25s ease-in-out;
  transition: all 0.25s ease-in-out;
}
.cid-s1YNw91RvB .collapsed .dropdown-menu .dropdown-item:before {
  display: none;
}
.cid-s1YNw91RvB .collapsed .dropdown .dropdown-menu .dropdown-item {
  padding: 0.235em 1.5em 0.235em 1.5em !important;
  transition: none;
}
.cid-s1YNw91RvB .navbar-brand {
  -webkit-flex-shrink: 0;
  flex-shrink: 0;
  -webkit-align-items: center;
  align-items: center;
  margin-right: 0;
  padding: 0;
  transition: all .3s;
  word-break: break-word;
  z-index: 1;
}
.cid-s1YNw91RvB .navbar-brand .navbar-caption {
  line-height: inherit !important;
}
.cid-s1YNw91RvB .navbar-brand .navbar-logo a {
  outline: none;
}
.cid-s1YNw91RvB .dropdown-item.active,
.cid-s1YNw91RvB .dropdown-item:active {
  background-color: transparent;
}
.cid-s1YNw91RvB .navbar-expand-lg .navbar-nav .nav-link {
  padding: 0;
}
.cid-s1YNw91RvB .nav-dropdown .link.dropdown-toggle {
  margin-right: 1.667em;
}
.cid-s1YNw91RvB .nav-dropdown .link.dropdown-toggle[aria-expanded="true"] {
  margin-right: 0;
  padding: 0.667em 1.667em;
}
.cid-s1YNw91RvB .navbar.navbar-expand-lg .dropdown .dropdown-menu {
  background: #040402;
}
.cid-s1YNw91RvB .navbar.navbar-expand-lg .dropdown .dropdown-menu .dropdown-submenu {
  margin: 0;
  left: 100%;
}
.cid-s1YNw91RvB .navbar .dropdown.open > .dropdown-menu {
  display: block;
}
.cid-s1YNw91RvB ul.navbar-nav {
  -webkit-flex-wrap: wrap;
  flex-wrap: wrap;
}
.cid-s1YNw91RvB .navbar-buttons {
  text-align: center;
  min-width: 170px;
}
.cid-s1YNw91RvB button.navbar-toggler {
  outline: none;
  width: 31px;
  height: 20px;
  cursor: pointer;
  transition: all .2s;
  position: relative;
  -webkit-align-self: center;
  align-self: center;
}
.cid-s1YNw91RvB button.navbar-toggler .hamburger span {
  position: absolute;
  right: 0;
  width: 30px;
  height: 2px;
  border-right: 5px;
  background-color: #ffffff;
}
.cid-s1YNw91RvB button.navbar-toggler .hamburger span:nth-child(1) {
  top: 0;
  transition: all .2s;
}
.cid-s1YNw91RvB button.navbar-toggler .hamburger span:nth-child(2) {
  top: 8px;
  transition: all .15s;
}
.cid-s1YNw91RvB button.navbar-toggler .hamburger span:nth-child(3) {
  top: 8px;
  transition: all .15s;
}
.cid-s1YNw91RvB button.navbar-toggler .hamburger span:nth-child(4) {
  top: 16px;
  transition: all .2s;
}
.cid-s1YNw91RvB nav.opened .hamburger span:nth-child(1) {
  top: 8px;
  width: 0;
  opacity: 0;
  right: 50%;
  transition: all .2s;
}
.cid-s1YNw91RvB nav.opened .hamburger span:nth-child(2) {
  -webkit-transform: rotate(45deg);
  transform: rotate(45deg);
  transition: all .25s;
}
.cid-s1YNw91RvB nav.opened .hamburger span:nth-child(3) {
  -webkit-transform: rotate(-45deg);
  transform: rotate(-45deg);
  transition: all .25s;
}
.cid-s1YNw91RvB nav.opened .hamburger span:nth-child(4) {
  top: 8px;
  width: 0;
  opacity: 0;
  right: 50%;
  transition: all .2s;
}
.cid-s1YNw91RvB .navbar-dropdown {
  padding: .5rem 1rem;
  position: fixed;
}
.cid-s1YNw91RvB a.nav-link {
  display: flex;
  -webkit-align-items: center;
  align-items: center;
  -webkit-justify-content: center;
  justify-content: center;
}
.cid-s1YNw91RvB .icons-menu {
  -webkit-flex-wrap: wrap;
  flex-wrap: wrap;
  min-width: 160px;
  display: flex;
  -webkit-justify-content: center;
  justify-content: center;
  padding-left: 1rem;
  padding-right: 1rem;
  padding-top: 0.3rem;
  text-align: center;
}
.cid-s1YNw91RvB .icons-menu span {
  font-size: 20px;
  color: #ffffff;
}
@media screen and (-ms-high-contrast: active), (-ms-high-contrast: none) {
  .cid-s1YNw91RvB .navbar {
    height: 77px;
  }
  .cid-s1YNw91RvB .navbar.opened {
    height: auto;
  }
  .cid-s1YNw91RvB .nav-item .nav-link:hover::before {
    width: 175%;
    max-width: calc(100% + 2rem);
    left: -1rem;
  }
}
.cid-s1YNw91RvB .nav-link {
  margin: auto!important;
  position: relative;
  cursor: pointer;
  display: inline-block;
  width: fit-content;
  transition: all 0.3s;
}
.cid-s1YNmF9EpW {
  padding-top: 165px;
  padding-bottom: 150px;
  background-image: url("https://i.imgur.com/zjL9bNQ.png");
}
.cid-s1YNmF9EpW H1 {
  color: #5758e0;
}
.cid-s1YNmF9EpW h1 {
  background: linear-gradient(to left, #55b4d4, currentColor);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.cid-s1YNmF9EpW .mbr-text,
.cid-s1YNmF9EpW .mbr-section-btn {
  color: #999999;
}
.cid-s1YNzGfN84 {
  padding-top: 105px;
  padding-bottom: 75px;
  background-color: #111111;
}
.cid-s1YNzGfN84 img {
  width: 100%;
  transition: all 0.6s ease-in-out;
  height: 260px;
  object-fit: cover;
}
.cid-s1YNzGfN84 .link-wrapper {
  margin-bottom: 1rem;
}
.cid-s1YNzGfN84 .link-wrapper .mbr-iconfont {
  border: 1px solid #999999;
  border-radius: 50%;
  padding: 8px;
  font-size: 0.8rem;
  color: #999999;
}
.cid-s1YNzGfN84 .img-wrapper .mbr-iconfont {
  font-size: 3rem;
  width: 80px;
  height: 80px;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: auto;
  padding-bottom: 1rem;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.cid-s1YNzGfN84 .card-wrapper {
  background: #191919;
  padding: 2rem;
}
@media (max-width: 767px) {
  .cid-s1YNzGfN84 .card-wrapper {
    padding: 2rem 1rem;
  }
}
.cid-s1YNzGfN84 .first:hover:before {
  content: none;
}
.cid-s1YNzGfN84 .first:before {
  position: absolute;
  top: -1rem;
  z-index: -1;
  left: 0rem;
  width: 300px;
  height: 200px;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  content: '';
}
.cid-s1YNzGfN84 .last:hover:after {
  content: none;
}
.cid-s1YNzGfN84 .last:after {
  position: absolute;
  bottom: -1rem;
  right: 0rem;
  width: 300px;
  z-index: -1;
  height: 200px;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  content: '';
}
.cid-s1YNzGfN84 .mbr-section-text {
  color: #999999;
}
.cid-s1YNzGfN84 .card {
  z-index: 1;
  min-height: 200px;
  margin-bottom: 2rem;
  position: relative;
  transition: all 0.3s;
}
.cid-s1YNzGfN84 .card .img-wrapper {
  overflow: hidden;
}
.cid-s1YNzGfN84 .card:hover {
  transform: translateY(-10px);
  cursor: pointer;
}
.cid-s1YNzGfN84 .card:hover .mbr-iconfont {
  color: #ffffff !important;
  border-color: #ffffff;
  -webkit-background-clip: transparent;
  -webkit-text-fill-color: unset;
}
.cid-s1YNzGfN84 .card:hover .card-wrapper {
  background: linear-gradient(to left, #55b4d4, #5758e0);
  color: #ffffff !important;
}
.cid-s1YNzGfN84 .card:hover .card-wrapper .mbr-section-text {
  color: #ffffff !important;
}
.cid-s1YQ6E1SFC {
  padding-top: 90px;
  padding-bottom: 90px;
  background-color: #191919;
}
.cid-s1YQ6E1SFC .line {
  width: 55px;
  margin-bottom: 0.5rem;
  height: 5px;
  display: inline-block;
  background: linear-gradient(to left, #55b4d4, #5758e0);
}
.cid-s1YQ6E1SFC .mbr-text,
.cid-s1YQ6E1SFC .mbr-section-btn {
  color: #999999;
}
.cid-s1YQ6E1SFC img {
  width: 100%;
}
@media (min-width: 992px) {
  .cid-s1YQ6E1SFC img {
    width: 96%;
  }
}
.cid-s1YPl57Et0 {
  padding-top: 135px;
  padding-bottom: 135px;
  background-color: #111111;
}
.cid-s1YPl57Et0 .card-wrapper {
  display: flex;
  padding: 0 1.5rem;
}
@media (max-width: 1600px) {
  .cid-s1YPl57Et0 .card-wrapper {
    padding: 0;
  }
}
.cid-s1YPl57Et0 img {
  width: 100%;
}
.cid-s1YPl57Et0 .mbr-iconfont {
  font-size: 3rem;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.cid-s1YPl57Et0 .line {
  width: 55px;
  margin-bottom: 0.5rem;
  height: 5px;
  display: inline-block;
  background: linear-gradient(to left, #55b4d4, #5758e0);
}
.cid-s1YPl57Et0 .icon-wrapper {
  margin: auto;
  margin-right: 1.5rem;
  display: flex;
  justify-content: center;
  border-radius: 50%;
}
.cid-s1YPl57Et0 h4 {
  margin: 0;
}
.cid-s1YPl57Et0 .card-text {
  color: #999999;
}
.cid-s1YPl57Et0 .mbr-text {
  color: #000000;
}
.cid-s1YPl57Et0 .card-title {
  color: #ffffff;
}
@media (min-width: 1200px) {
  .cid-s1YPl57Et0 .mbr-text {
    max-width: 600px;
  }
}
@media (max-width: 767px) {
  .cid-s1YPl57Et0 .card-wrapper {
    flex-direction: column;
    margin: auto;
    text-align: center;
  }
  .cid-s1YPl57Et0 .card-wrapper .icon-wrapper {
    margin: 0 auto;
    margin-bottom: 1rem;
  }
}
@media (max-width: 991px) {
  .cid-s1YPl57Et0 .mbr-text {
    padding-bottom: 2rem;
    max-width: 100%;
  }
}
.cid-s1YPl57Et0 H3 {
  color: #787324;
}
.cid-s1YPl57Et0 .mbr-section-title,
.cid-s1YPl57Et0 .title-wrapper {
  color: #ffffff;
}
.cid-s1YPl57Et0 .mbr-text,
.cid-s1YPl57Et0 .mbr-section-btn {
  color: #999999;
}
.cid-s1YPFUMG3v {
  padding-top: 90px;
  padding-bottom: 90px;
  position: relative;
  background-color: #000000;
}
.cid-s1YPFUMG3v p {
  color: #767676;
  padding: 0;
  letter-spacing: 0px;
}
.cid-s1YPFUMG3v .panel-title {
  border-bottom: 2px solid #5758e0;
  display: flex!important;
  justify-content: space-between;
  align-items: center;
  padding-right: 2rem;
}
.cid-s1YPFUMG3v .collapsed {
  border: none;
}
.cid-s1YPFUMG3v .collapsed span {
  transform: rotate(0deg);
}
.cid-s1YPFUMG3v span {
  font-size: 1.4rem;
  transition: all 0.3s;
  transform: rotate(45deg);
  background: linear-gradient(to left, #55b4d4, #5758e0);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  font-weight: 900;
}
.cid-s1YPFUMG3v .panel-body {
  padding-top: 0.5rem;
}
.cid-s1YPFUMG3v .card {
  border-radius: 0px;
  margin-bottom: -1px;
}
.cid-s1YPFUMG3v .card .card-header {
  border-radius: 0px;
  margin: 0.5rem 0;
  border: 0px;
  background: #191919;
  padding: 0;
}
.cid-s1YPFUMG3v .card .card-header a.panel-title {
  margin-bottom: 0;
  margin-top: -1px;
  font-style: normal;
  text-decoration: none !important;
  line-height: normal;
}
.cid-s1YPFUMG3v .card .card-header a.panel-title:focus {
  text-decoration: none !important;
}
.cid-s1YPFUMG3v .card .card-header a.panel-title h4 {
  padding: 1.3rem 2rem;
  margin-bottom: 0;
}
.cid-s1YPFUMG3v .card .card-header a.panel-title h4 .sign {
  padding-right: 1rem;
}
.cid-s1YPFUMG3v .panel-text {
  color: #767676;
}
.cid-s1YPFUMG3v H4 {
  color: #999999;
}
.cid-s1YPFUMG3v H2 {
  color: #ffffff;
}
.cid-s1YPFUMG3v .mbr-section-text {
  color: #999999;
}
.cid-s1YQ4DrGok {
  padding-top: 75px;
  padding-bottom: 75px;
  background-color: #111111;
}
.cid-s1YQ4DrGok .card-box {
  padding: 0 1rem;
  position: relative;
  z-index: 2;
}
.cid-s1YQ4DrGok .card-img {
  padding-bottom: 1rem;
}
.cid-s1YQ4DrGok .card {
  cursor: pointer;
  transition: all 0.3s;
}
.cid-s1YQ4DrGok .card:hover {
  transform: translateY(-10px);
}
.cid-s1YQ4DrGok .mbr-text,
.cid-s1YQ4DrGok .card-title {
  opacity: 0;
}
.cid-s1YQ4DrGok .card-wrapper {
  display: flex;
  justify-content: center;
  padding: 1rem;
  background-position: center;
  background-size: cover;
  padding-top: 15rem;
  align-items: center;
  perspective: 300px;
  height: 100%;
}
.cid-s1YQ4DrGok .card-wrapper:after {
  position: absolute;
  content: '';
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: black;
  opacity: 0.2;
  z-index: 1;
}
@media (min-width: 992px) {
  .cid-s1YQ4DrGok .card:hover .card-wrapper:after {
    opacity: 0.8;
    background: linear-gradient(to left, #55b4d4, #5758e0);
  }
  .cid-s1YQ4DrGok .card:hover .mbr-text,
  .cid-s1YQ4DrGok .card:hover .card-title {
    opacity: 1;
  }
}
@media (max-width: 992px) {
  .cid-s1YQ4DrGok .card {
    padding-bottom: 1rem!important;
  }
  .cid-s1YQ4DrGok .card .mbr-text,
  .cid-s1YQ4DrGok .card .card-title {
    opacity: 1;
  }
  .cid-s1YQ4DrGok .card-wrapper:after {
    opacity: 0.7;
    background: linear-gradient(to left, #55b4d4, #5758e0);
  }
}
.cid-s1YQ4DrGok .row {
  justify-content: center;
}
.cid-s1YQ4DrGok .card-title {
  border-bottom: 1px solid #999999;
}
.cid-s1YQ4DrGok .card1 {
  background-image: url("../../../assets/images/04.jpg");
}
.cid-s1YQ4DrGok .card2 {
  background-image: url("../../../assets/images/020.jpg");
}
.cid-s1YQ4DrGok .card3 {
  background-image: url("../../../assets/images/031.jpg");
}
.cid-s1YQ4DrGok .link,
.cid-s1YQ4DrGok .card-box {
  color: #ffffff;
}
.cid-s1YQ4DrGok .mbr-text,
.cid-s1YQ4DrGok .link-wrap {
  text-align: center;
}
.cid-s1YQ4DrGok .main-subtitle {
  color: #ffffff;
}
.cid-s1YQ4DrGok .mbr-section-subtitle {
  color: #999999;
}
.cid-s1YQ4DrGok .mbr-section-text {
  color: #999999;
}
.cid-s1YPL0Q2c0 {
  padding-top: 120px;
  padding-bottom: 120px;
  background-color: #191919;
}
.cid-s1YPL0Q2c0 .wrapper {
  overflow: hidden;
  position: relative;
}
.cid-s1YPL0Q2c0 .mbr-media {
  z-index: 2;
}
.cid-s1YPL0Q2c0 .box {
  height: 400px;
  margin: auto;
  display: flex;
  align-items: center;
  justify-content: center;
  cursor: pointer;
}
.cid-s1YPL0Q2c0 .box:before {
  background-image: url("../../../assets/images/background1.jpg");
  background-size: cover;
  background-position: center;
  position: absolute;
  content: '';
  width: 100%;
  transition: all 0.3s;
  height: 100%;
  left: 0;
}
.cid-s1YPL0Q2c0 .box:hover span {
  transform: scale(1.2);
}
.cid-s1YPL0Q2c0 .box:hover:before {
  filter: contrast(1.2) brightness(0.8);
}
.cid-s1YPL0Q2c0 .icon-wrap {
  margin: auto;
  display: flex;
  justify-content: center;
  align-items: center;
  cursor: pointer;
}
.cid-s1YPL0Q2c0 .icon-wrap span {
  padding-left: 4px;
}
.cid-s1YPL0Q2c0 .mbr-media span {
  font-size: 6rem;
  cursor: pointer;
  position: relative;
  display: flex;
  transition: all 0.3s;
  justify-content: center;
  align-items: center;
  opacity: 1;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.cid-s1YPL0Q2c0 .mbr-media span.mbri-play:before {
  position: absolute;
  left: 50%;
  -webkit-transform: translateX(-35%);
  -moz-transform: translateX(-35%);
  -ms-transform: translateX(-35%);
  -o-transform: translateX(-35%);
  transform: translateX(-35%);
}
.cid-s1YPL0Q2c0 .modalWindow {
  position: fixed;
  z-index: 5000;
  left: 0;
  top: 0;
  background-color: rgba(61, 61, 61, 0.65);
  width: 100%;
  height: 100%;
}
.cid-s1YPL0Q2c0 .modalWindow .modalWindow-container {
  display: table-cell;
  vertical-align: middle;
}
.cid-s1YPL0Q2c0 .modalWindow .modalWindow-video {
  height: calc(44.9943757vw);
  width: 80vw;
  margin: 0 auto;
}
.cid-s1YPL0Q2c0 a.close {
  position: absolute;
  right: 4vw;
  top: 4vh;
  color: #ffffff;
  z-index: 5000000;
  font-size: 37px;
  background: #000;
  padding: 20px;
  border-radius: 50%;
}
.cid-s1YPL0Q2c0 a.close:hover {
  color: #ffffff;
}
@media (max-width: 576px) {
  .cid-s1YPL0Q2c0 .box {
    height: 250px;
  }
}
.cid-s1YPL0Q2c0 .mbr-section-title {
  color: #ffffff;
}
.cid-s1YPL0Q2c0 H4 {
  color: #000000;
}
.cid-s1YPL0Q2c0 P {
  color: #999999;
}
.cid-s1YPV5pGou {
  padding-top: 90px;
  padding-bottom: 90px;
  background-color: #000000;
}
.cid-s1YPV5pGou img {
  width: 100px;
  height: 100px;
  object-fit: cover;
  border-radius: 50%;
}
@media (min-width: 767px) {
  .cid-s1YPV5pGou .container-fluid {
    padding: 0 2rem;
  }
}
.cid-s1YPV5pGou .card-wrapper {
  background: #191919;
  padding: 3rem;
}
.cid-s1YPV5pGou .card-wrapper:hover {
  background: linear-gradient(to left, #55b4d4, #5758e0);
}
.cid-s1YPV5pGou .text-wrap {
  display: flex;
  justify-content: center;
  padding-top: 2rem;
}
.cid-s1YPV5pGou .icon-wrapper {
  padding: 0 0.6rem;
}
.cid-s1YPV5pGou .card-box {
  padding-top: 2rem;
}
.cid-s1YPV5pGou .link-icon {
  font-size: 1.5rem;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.cid-s1YPV5pGou .card-title {
  color: #999999;
}
.cid-s1YPV5pGou .mbr-subtitle {
  color: #ffffff;
}
.cid-s1YPV5pGou .main-title {
  color: #ffffff;
}
.cid-s1YPV5pGou .main-subtitle {
  color: #999999;
}
.cid-s1YPV5pGou .card {
  margin-bottom: 2rem;
  transition: all 0.3s;
}
.cid-s1YPV5pGou .card:hover {
  transform: translateY(-10px);
}
.cid-s1YPV5pGou .card:hover .link-icon {
  color: #ffffff;
  -webkit-background-clip: transparent;
  -webkit-text-fill-color: unset;
}
.cid-s1YPV5pGou .card:hover .card-title,
.cid-s1YPV5pGou .card:hover .mbr-subtitle {
  color: #ffffff !important;
}
@media (min-width: 1600px) {
  .cid-s1YPV5pGou .card {
    max-width: 20%;
  }
}
@media (max-width: 1600px) {
  .cid-s1YPV5pGou .card-wrapper {
    padding: 3rem 1rem;
  }
}
.cid-s1YPpR5DLc {
  padding-top: 135px;
  padding-bottom: 135px;
  background-color: #040402;
}
.cid-s1YPpR5DLc .card-wrapper {
  display: flex;
  padding: 0 1.5rem;
}
@media (max-width: 1600px) {
  .cid-s1YPpR5DLc .card-wrapper {
    padding: 0;
  }
}
.cid-s1YPpR5DLc .row {
  flex-direction: row-reverse;
}
.cid-s1YPpR5DLc .form-control,
.cid-s1YPpR5DLc .field-input {
  padding: 1rem;
}
.cid-s1YPpR5DLc .form-row > .col,
.cid-s1YPpR5DLc .col-auto {
  padding-right: 8px;
  padding-left: 8px;
}
.cid-s1YPpR5DLc .btn {
  margin: 0!important;
  height: 56px;
  border-radius: 3px!important;
  padding: 0 1.5rem;
}
.cid-s1YPpR5DLc .btn span {
  font-size: 1rem;
}
.cid-s1YPpR5DLc .form-control,
.cid-s1YPpR5DLc .field-input {
  padding: 1rem;
  background-color: #040402;
  border-color: #555555;
  color: #ffffff;
  transition: 0.4s;
  box-shadow: none;
  outline: none;
}
.cid-s1YPpR5DLc .form-control::-webkit-input-placeholder,
.cid-s1YPpR5DLc .field-input::-webkit-input-placeholder,
.cid-s1YPpR5DLc .form-control::-webkit-input-placeholder,
.cid-s1YPpR5DLc .field-input::-webkit-input-placeholder {
  color: #999999;
}
.cid-s1YPpR5DLc .form-control:-moz-placeholder,
.cid-s1YPpR5DLc .field-input:-moz-placeholder,
.cid-s1YPpR5DLc .form-control:-moz-placeholder,
.cid-s1YPpR5DLc .field-input:-moz-placeholder {
  color: #999999;
}
.cid-s1YPpR5DLc .form-control:hover,
.cid-s1YPpR5DLc .field-input:hover,
.cid-s1YPpR5DLc .form-control:focus,
.cid-s1YPpR5DLc .field-input:focus {
  background-color: #040402;
  border-color: #555555;
  color: #ffffff;
  box-shadow: none;
  outline: none;
}
.cid-s1YPpR5DLc .form-control:hover::-webkit-input-placeholder,
.cid-s1YPpR5DLc .field-input:hover::-webkit-input-placeholder,
.cid-s1YPpR5DLc .form-control:focus::-webkit-input-placeholder,
.cid-s1YPpR5DLc .field-input:focus::-webkit-input-placeholder,
.cid-s1YPpR5DLc .form-control:hover::-webkit-input-placeholder,
.cid-s1YPpR5DLc .field-input:hover::-webkit-input-placeholder,
.cid-s1YPpR5DLc .form-control:focus::-webkit-input-placeholder,
.cid-s1YPpR5DLc .field-input:focus::-webkit-input-placeholder {
  color: #999999;
}
.cid-s1YPpR5DLc .form-control:hover:-moz-placeholder,
.cid-s1YPpR5DLc .field-input:hover:-moz-placeholder,
.cid-s1YPpR5DLc .form-control:focus:-moz-placeholder,
.cid-s1YPpR5DLc .field-input:focus:-moz-placeholder,
.cid-s1YPpR5DLc .form-control:hover:-moz-placeholder,
.cid-s1YPpR5DLc .field-input:hover:-moz-placeholder,
.cid-s1YPpR5DLc .form-control:focus:-moz-placeholder,
.cid-s1YPpR5DLc .field-input:focus:-moz-placeholder {
  color: #999999;
}
.cid-s1YPpR5DLc .jq-number__spin:hover,
.cid-s1YPpR5DLc .jq-number__spin:focus {
  background-color: #040402;
  border-color: #555555;
  color: #000000;
  box-shadow: none;
  outline: none;
}
.cid-s1YPpR5DLc .jq-number__spin {
  background-color: #040402;
  border-color: #555555;
  color: #ffffff;
  transition: 0.4s;
  box-shadow: none;
  outline: none;
}
.cid-s1YPpR5DLc .jq-selectbox li,
.cid-s1YPpR5DLc .jq-selectbox li {
  background-color: #040402;
  color: #ffffff;
}
.cid-s1YPpR5DLc .jq-selectbox li:hover,
.cid-s1YPpR5DLc .jq-selectbox li.selected {
  background-color: #040402;
  color: #ffffff;
}
.cid-s1YPpR5DLc .jq-selectbox:hover .jq-selectbox__trigger-arrow,
.cid-s1YPpR5DLc .jq-number__spin.minus:hover:after,
.cid-s1YPpR5DLc .jq-number__spin.plus:hover:after {
  border-top-color: #040402;
  border-bottom-color: #040402;
}
.cid-s1YPpR5DLc .jq-selectbox .jq-selectbox__trigger-arrow,
.cid-s1YPpR5DLc .jq-number__spin.minus:after,
.cid-s1YPpR5DLc .jq-number__spin.plus:after {
  border-top-color: #040402;
  border-bottom-color: #040402;
}
.cid-s1YPpR5DLc input::-webkit-clear-button {
  display: none;
}
.cid-s1YPpR5DLc input::-webkit-inner-spin-button {
  display: none;
}
.cid-s1YPpR5DLc input::-webkit-outer-spin-button {
  display: none;
}
.cid-s1YPpR5DLc input::-webkit-calendar-picker-indicator {
  display: none;
}
.cid-s1YPpR5DLc H4 {
  color: #ffffff;
}
.cid-s1YPpR5DLc P {
  color: #999999;
}
@media (max-width: 767px) {
  .cid-s1YPpR5DLc .col {
    min-width: 100%;
  }
  .cid-s1YPpR5DLc .col-auto {
    margin: auto;
  }
  .cid-s1YPpR5DLc .card-wrapper {
    flex-direction: column;
    margin: auto;
    text-align: center;
  }
  .cid-s1YPpR5DLc .card-wrapper .icon-wrapper {
    margin: 0 auto;
    margin-bottom: 1rem;
  }
}
.cid-s1YPpR5DLc .content {
  padding: 0 3rem;
}
@media (max-width: 1600px) {
  .cid-s1YPpR5DLc .content {
    padding: 0 1rem;
  }
}
.cid-s1YPpR5DLc .img-wrapper {
  position: relative;
  overflow: hidden;
}
.cid-s1YPpR5DLc .img-wrapper:before {
  content: '';
  position: absolute;
  width: 600px;
  height: 600px;
  right: -300px;
  border-radius: 50%;
  bottom: -350px;
  opacity: 0.3;
  background: #5758e0;
  z-index: 2;
  pointer-events: none;
}
.cid-s1YPpR5DLc img {
  width: 100%;
}
.cid-s1YPpR5DLc .card-wrapper .mbr-iconfont {
  font-size: 3rem;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.cid-s1YPpR5DLc .line {
  width: 55px;
  margin-bottom: 0.5rem;
  height: 5px;
  display: inline-block;
  background: linear-gradient(to left, #55b4d4, #5758e0);
}
.cid-s1YPpR5DLc .icon-wrapper {
  margin: auto;
  margin-right: 1.5rem;
  display: flex;
  justify-content: center;
  border-radius: 50%;
}
.cid-s1YPpR5DLc h4 {
  margin: 0;
}
.cid-s1YPpR5DLc .card-text {
  color: #999999;
}
.cid-s1YPpR5DLc .mbr-text {
  color: #000000;
}
.cid-s1YPpR5DLc .card-title {
  color: #ffffff;
}
@media (min-width: 1200px) {
  .cid-s1YPpR5DLc .mbr-text {
    max-width: 600px;
  }
}
@media (max-width: 991px) {
  .cid-s1YPpR5DLc .mbr-text {
    padding-bottom: 2rem;
    max-width: 100%;
  }
}
.cid-s1YPpR5DLc .icon-wrap {
  background: linear-gradient(to left, #55b4d4, #5758e0);
  width: 100px;
  height: 100px;
  display: flex;
  cursor: pointer;
  justify-content: center;
  align-items: center;
  border-radius: 50%;
  z-index: 5;
  position: absolute;
  bottom: 3rem;
  right: 3rem;
}
.cid-s1YPpR5DLc .icon-wrap .mbr-iconfont {
  font-size: 2.6rem;
  color: white;
  padding-left: 10px;
}
.cid-s1YPpR5DLc H3 {
  color: #787324;
}
.cid-s1YPpR5DLc .mbr-section-title,
.cid-s1YPpR5DLc .title-wrapper {
  color: #ffffff;
}
.cid-s1YPpR5DLc .mbr-text,
.cid-s1YPpR5DLc .mbr-section-btn {
  color: #999999;
}
.cid-s1YPpR5DLc .modalWindow {
  position: fixed;
  z-index: 5000;
  left: 0;
  top: 0;
  background-color: rgba(61, 61, 61, 0.65);
  width: 100%;
  height: 100%;
}
.cid-s1YPpR5DLc .modalWindow .modalWindow-container {
  display: table-cell;
  vertical-align: middle;
}
.cid-s1YPpR5DLc .modalWindow .modalWindow-video {
  height: calc(44.9943757vw);
  width: 80vw;
  margin: 0 auto;
}
.cid-s1YPpR5DLc a.close {
  position: absolute;
  right: 4vw;
  top: 4vh;
  color: #ffffff;
  z-index: 5000000;
  font-size: 37px;
  background: #000;
  padding: 20px;
  border-radius: 50%;
}
.cid-s1YPpR5DLc a.close:hover {
  color: #ffffff;
}
.cid-s1YPq9DXRB .google-map {
  height: 30rem;
  position: relative;
}
.cid-s1YPq9DXRB .google-map iframe {
  height: 100%;
  width: 100%;
}
.cid-s1YPq9DXRB .google-map [data-state-details] {
  color: #6b6763;
  font-family: Montserrat;
  height: 1.5em;
  margin-top: -0.75em;
  padding-left: 1.25rem;
  padding-right: 1.25rem;
  position: absolute;
  text-align: center;
  top: 50%;
  width: 100%;
}
.cid-s1YPq9DXRB .google-map[data-state] {
  background: #e9e5dc;
}
.cid-s1YPq9DXRB .google-map[data-state="loading"] [data-state-details] {
  display: none;
}
.cid-s1YPyUn2on {
  padding-top: 90px;
  padding-bottom: 75px;
  background-color: #111111;
}
.cid-s1YPyUn2on img {
  width: 100%;
  transition: all 0.6s ease-in-out;
  height: 260px;
  object-fit: cover;
}
.cid-s1YPyUn2on .link-wrapper {
  margin-bottom: 1rem;
}
.cid-s1YPyUn2on .link-wrapper .mbr-iconfont {
  border: 1px solid #999999;
  border-radius: 50%;
  padding: 8px;
  font-size: 0.8rem;
  color: #999999;
}
.cid-s1YPyUn2on .img-wrapper .mbr-iconfont {
  font-size: 3rem;
  width: 80px;
  height: 80px;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: auto;
  padding-bottom: 1rem;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.cid-s1YPyUn2on .card-wrapper {
  background: #191919;
  padding: 2rem;
}
@media (max-width: 767px) {
  .cid-s1YPyUn2on .card-wrapper {
    padding: 2rem 1rem;
  }
}
.cid-s1YPyUn2on .first:hover:before {
  content: none;
}
.cid-s1YPyUn2on .first:before {
  position: absolute;
  top: -1rem;
  z-index: -1;
  left: 0rem;
  width: 300px;
  height: 200px;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  content: '';
}
.cid-s1YPyUn2on .last:hover:after {
  content: none;
}
.cid-s1YPyUn2on .last:after {
  position: absolute;
  bottom: -1rem;
  right: 0rem;
  width: 300px;
  z-index: -1;
  height: 200px;
  background: linear-gradient(to left, #55b4d4, #5758e0);
  content: '';
}
.cid-s1YPyUn2on .mbr-section-text {
  color: #999999;
}
.cid-s1YPyUn2on .card {
  z-index: 1;
  min-height: 200px;
  margin-bottom: 2rem;
  position: relative;
  transition: all 0.3s;
}
.cid-s1YPyUn2on .card .img-wrapper {
  overflow: hidden;
}
.cid-s1YPyUn2on .card:hover {
  transform: translateY(-10px);
  cursor: pointer;
}
.cid-s1YPyUn2on .card:hover .mbr-iconfont {
  color: #ffffff !important;
  border-color: #ffffff;
  -webkit-background-clip: transparent;
  -webkit-text-fill-color: unset;
}
.cid-s1YPyUn2on .card:hover .card-wrapper {
  background: linear-gradient(to left, #55b4d4, #5758e0);
  color: #ffffff !important;
}
.cid-s1YPyUn2on .card:hover .card-wrapper .mbr-section-text {
  color: #ffffff !important;
}
.cid-s1YPqSpOCZ {
  padding-top: 30px;
  padding-bottom: 30px;
  background-color: #040402;
}
.cid-s1YPqSpOCZ .mbr-text1 {
  color: #999999;
}
.cid-s1YPqSpOCZ .mbr-text2 {
  color: #999999;
}
.cid-s1YPqSpOCZ p {
  margin: 0;
}
