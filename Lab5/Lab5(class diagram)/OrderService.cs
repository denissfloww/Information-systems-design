
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// @author Gena Peryatin
/// </summary>
public class OrderService {

    public OrderService() {
    }

    /// <summary>
    /// @param userId 
    /// @param filter
    /// </summary>
    public void GetOrders(int userId, Filter filter) {
        // TODO implement here
    }

    /// <summary>
    /// @param orderId
    /// </summary>
    public void GetOrder(int orderId) {
        // TODO implement here
    }

    /// <summary>
    /// @param userId 
    /// @param orderId 
    /// @param planId 
    /// @param scan
    /// </summary>
    public void UpdateOrder(int userId, int orderId, int planId, string scan) {
        // TODO implement here
    }

    /// <summary>
    /// @param data
    /// </summary>
    public void ExportOrders(List data) {
        // TODO implement here
    }

    /// <summary>
    /// @param data
    /// </summary>
    public void ExportOrder(object data) {
        // TODO implement here
    }

    /// <summary>
    /// @param userId 
    /// @param planId
    /// </summary>
    public void DreateOrder(int userId, int planId) {
        // TODO implement here
    }

    /// <summary>
    /// @param userId 
    /// @param orderId
    /// </summary>
    public void DeleteOrder(int userId, int orderId) {
        // TODO implement here
    }

    /// <summary>
    /// @param userId 
    /// @param attributes 
    /// @param values
    /// </summary>
    public void FilterOrders(int userId, List attributes, List values) {
        // TODO implement here
    }

    /// <summary>
    /// @param userId 
    /// @param attribute 
    /// @param sortOrder
    /// </summary>
    public void SortOrders(int userId, string attribute, string sortOrder) {
        // TODO implement here
    }

}