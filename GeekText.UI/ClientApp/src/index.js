import React from "react";
import ReactDOM from "react-dom";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";

// Redux
import { Provider } from "react-redux";
import store from "./redux/store";

import Home from "./components/Home";
import SiteContainer from "./components/site-container";
import LoginPage from "./components/login-page";
import Wishlists from "./components/wishlists";

import "./index.css";
import * as serviceWorker from "./serviceWorker";

ReactDOM.render(
	<Provider store={store}>
		<Router>
			<SiteContainer>
				<Switch>
					<Route path="/example-route">
						Hello world.
					</Route>
					<Route path="/wishlists">
						<Wishlists/>
					</Route>
					<Route path="/login">
						<LoginPage/>
					</Route>
					<Route path="/">
						<Home/>
					</Route>
				</Switch>
			</SiteContainer>
		</Router>
	</Provider>,
	document.getElementById("root")
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
