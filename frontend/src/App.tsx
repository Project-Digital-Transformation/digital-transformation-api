import React from 'react';
import './App.css';
import { BrowserRouter as Router, Route, Routes, Link } from 'react-router-dom';
import Home from "./Home/Home";
import Products from './Products/Products';
import Orders from './Orders/Orders';
import OrderDetail from './Orders/OrderDetail';
import PaymentScreen from './Payment/Payment';

function App() {
    const openMenu = () => {
        document.querySelector(".sidebar")?.classList.add("open");
    }

    const closeMenu = () => {
        document.querySelector(".sidebar")?.classList.remove("open");
    }
    return (
        <Router>
            <div className="grid-container">
                <link rel="stylesheet" href="style.css" />

                <body>
                    <div>
                        <header className="header">
                            <div className="brand">

                                <button onClick={() => openMenu()}>&#9776;</button>
                                {/*i modified this line (line 27)from the project because it was throwing an error. change it back to:
                                <button onClick={openMenu}>&#9776;</button>
                                if it's giving you trouble. more info on slide #17 of the instructions
                                */}
                                <a href="index.html">Jet Piranha</a>
                            </div>
                            <div className="header-links">
                                <Link to="/">Home</Link>
                                <Link to="/catalog">Catalog</Link>
                                <Link to="/orders">Orders</Link>
                                <Link to="/payment">Payment</Link>
                            </div>
                        </header>




                        <aside className="sidebar">
                            <h3>Shopping Categories</h3>

                            {/* same comment as line 27. see slide #17 if there's an error being thrown for you on line 48 */}
                            <button className="sidebar-close-button" onClick={() => closeMenu()}>&#9776;
                                X
                            </button>
                            <ul>
                                <li>
                                    <a href="index.html">Pants</a>
                                </li>

                                <li>
                                    <a href="index.html">Shirts</a>
                                </li>
                            </ul>
                        </aside>
                        <main className="main">
                            <Routes>
                                <Route path="/" element={<Home />} />
                                <Route path="/catalog" element={<Products />} />
                                <Route path="orders" element={<Orders />}></Route>
                                <Route path="/order/:id" element={<OrderDetail />}></Route>
                                <Route path="payment" element={<PaymentScreen />}></Route>
                            </Routes>

                        </main>
                        <footer>&copy; 2024 Jet Piranha</footer>
                    </div>
                </body>
            </div>
        </Router>
    );
}

export default App;