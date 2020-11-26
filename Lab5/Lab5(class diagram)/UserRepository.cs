
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// @author Gena Peryatin
/// </summary>
public class UserRepository : GenericRepository {

    public UserRepository() {
    }

    /// <summary>
    /// @param TEntitry
    /// </summary>
    public void Create(T TEntitry) {
        // TODO implement here
    }

    /// <summary>
    /// @param id 
    /// @return
    /// </summary>
    public T GetById(int id) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public T[] Get() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param predicate 
    /// @return
    /// </summary>
    public T[] Get(void predicate) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param item
    /// </summary>
    public void Update(T item) {
        // TODO implement here
    }

    /// <summary>
    /// @param item
    /// </summary>
    public void Remove(T item) {
        // TODO implement here
    }

    /// <summary>
    /// @param username 
    /// @param password
    /// </summary>
    public void CheckCredentials(void username, void password) {
        // TODO implement here
    }

}