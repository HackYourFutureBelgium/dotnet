import React from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import { Container } from "reactstrap";
import Loading from "./components/Loading";
import NavBar from "./components/Navbar";
import Home from "./views/Home";
import Profile from "./views/Profile";
import Functionality from "./views/Functionality";
import { useAuth0 } from "@auth0/auth0-react";
import history from "./utils/history";
import initFontAwesome from "./utils/initFontAwesome";

// styles
import "./App.css";

initFontAwesome();

const App = () => {
  const { isLoading, error } = useAuth0();

  if (error) {
    return <div>Oops... {error.message}</div>;
  }

  if (isLoading) {
    return (
      <div className="App">
        <Loading />
      </div>
    );
  }

  return (
    <BrowserRouter history={history}>
      <div className="App">
        <NavBar />
        <Container className="flex-grow-1 mt-5">
          <Routes>
            <Route index element={<Home />} />
            <Route path="profile" element={<Profile />} />
            <Route path="functionality" element={<Functionality />} />
          </Routes>
        </Container>
      </div>
    </BrowserRouter>
  );
}

export default App;
